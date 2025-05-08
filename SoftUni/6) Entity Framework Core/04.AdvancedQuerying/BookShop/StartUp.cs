namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Microsoft.EntityFrameworkCore.Storage;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();

            var input = Console.ReadLine().ToLower();

            var result = GetBooksByAgeRestriction(db, input);
            Console.WriteLine(result);
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var result = context.Books
                .Where(x => x.AgeRestriction.ToString().ToLower() == command)
                .OrderBy(x => x.Title)
                .Select(x => x.Title)
                .ToList();

            return string.Join(Environment.NewLine, result);
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var result = context.Books
                .Where(x => x.EditionType.ToString() == "Gold")
                .Where(x => x.Copies < 5000)
                .OrderBy(x => x.BookId)
                .Select(x => new
                {
                    BookTitle = x.Title
                })
                .ToList();

            return string.Join(Environment.NewLine, result);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            var result = context.Books
                .Where(x => x.Price > 40)
                .OrderByDescending(x => x.Price)
                .Select(x => new
                {
                    BookTitle = x.Title,
                    BookPrice = x.Price
                })
                .ToList();

            foreach (var b in result)
            {
                sb.AppendLine($"{b.BookTitle} - {b.BookPrice}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var result = context.Books
                .Where(x => x.ReleaseDate.HasValue && x.ReleaseDate.Value.Year != year)
                .OrderBy(x => x.BookId)
                .Select(x => x.Title)
                .ToList();

            return string.Join(Environment.NewLine, result);
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var categories = input.ToLower().Split(" ");

            var result = context.Books
                .Where(b => b.BookCategories
                    .Any(bc => categories.Contains(bc.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(title => title)
                .ToList();

            return string.Join(Environment.NewLine, result);
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();

            var parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(x => x.ReleaseDate.HasValue && x.ReleaseDate.Value < parsedDate)
                .OrderByDescending(x => x.ReleaseDate)
                .Select(x => new
                {
                    Title = x.Title,
                    EditionType = x.EditionType,
                    Price = x.Price
                })
                .ToList();

            foreach (var item in books)
            {
                sb.AppendLine($"{item.Title} - {item.EditionType} - {item.Price}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var result = context.Authors
                .Where(x => x.FirstName.EndsWith(input))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => x.FirstName + " " + x.LastName)
                .ToList();

            return string.Join(Environment.NewLine, result);
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var result = context.Books
                .Where(x => x.Title.Contains(input))
                .OrderBy(x => x.Title)
                .Select (x => x.Title)
                .ToList();

            return string.Join (Environment.NewLine, result);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var result = context.Books
                .Where(x => x.Author.LastName.StartsWith(input))
                .OrderBy(x => x.BookId)
                .Select(x => x.Title + " " + x.Author.FirstName + " " + x.Author.LastName)
                .ToList();

            return string.Join(Environment.NewLine, result);
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var result = context.Books
                .Where(x => x.Title.Length > lengthCheck)
                .Select(x => x.BookId)
                .ToList();

            return result.Count;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var result = context.Authors
                .OrderByDescending(x => x.Books.Count())
                .Select(x => new
                {
                    Author = x.FirstName + " " + x.LastName,
                    Copies = x.Books.Count()
                })
                .ToList();

            return String.Join(Environment.NewLine, string.Join(" ", result));
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            var result = context.Categories
                .Select(x => new
                {
                    CategoryName = x.Name,
                    Copies = x.CategoryBooks.Sum(x => x.Copies),
                    Price = x.CategoryBooks.Sum(x => x.Price)
                })
                .ToList();

            foreach (var item in result)
            {
                sb.AppendLine($"{item.CategoryName} ${item.Copies * item.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var bookCategories = context.Categories
                .OrderBy(x => x.Name)
                .Select(x => new
                {
                    CategoryTitle = x.Name,
                    FirstThreeBooks = x.CategoryBooks
                        .OrderByDescending(x => x.ReleaseDate)
                        .Take(3)
                        .Select(x => new
                        {
                            BookTitle = x.Title,
                            ReleaseYear = x.ReleaseDate.Value.Year
                        })
                        .ToList()
                })
                .ToList();

            foreach (var category in bookCategories)
            {
                sb.AppendLine("--" + category.CategoryTitle);

                foreach (var book in category.FirstThreeBooks)
                {
                    sb.AppendLine($"{book.BookTitle} ({book.ReleaseYear})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var booksPrices = context.Books
                .Where(x => x.ReleaseDate.HasValue && x.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var book in booksPrices)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var totalBooksCount = context.Books.ToList().Count();

            var filterBooksCOunt = context.Books
                .Where(x => x.Copies < 4200)
                .ToList()
                .Count();
            
            return totalBooksCount - filterBooksCOunt;
        }
    }
}