namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System.Globalization;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            // DbInitializer.ResetDatabase(db);

            

            var result = GetTotalProfitByCategory(db);
            Console.WriteLine(result);

        }

        //01.Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            var ageRestriction = Enum.Parse(typeof(AgeRestriction), command, true);

            var result = context
                .Books
                .OrderBy(x => x.Title)
                .Where(x => x.AgeRestriction.Equals(ageRestriction))
                .Select(x => x.Title)
                .ToList();

            result.ForEach(b => sb.AppendLine(b));

            return sb.ToString().TrimEnd();
        }

        //02. Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            var result = context.Books
                .Where(b => b.Copies < 5000 && b.EditionType.Equals(EditionType.Gold))
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            result.ForEach(b => sb.AppendLine(b));

            return sb.ToString().Trim();
        }

        //03. Book by Price
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

            foreach (var book in result)
            {
                sb
                    .AppendLine($"{book.BookTitle} - {book.BookPrice:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        //04. Not Released In*
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var sb = new StringBuilder();

            var bookTitles = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.GetValueOrDefault().Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            bookTitles.ForEach(b => sb.AppendLine(b));

            return sb.ToString().Trim();
        }

        //05. Book Titles by Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var result = context.Books
                .Where(x => x.BookCategories.Any(x => input.Contains(x.Category.Name.ToLower())))
                .OrderBy(x => x.Title)
                .Select(x => new
                {
                    BookTitle = x.Title,
                    x.BookCategories
                })
                .ToList();

            foreach (var book in result)
            {
                sb
                    .AppendLine(book.BookTitle);
            }

            return sb.ToString().Trim();
        }

        //06. Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();

            var format = "dd-MM-yyyy";
            var concrateDate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);

            var result = context.Books
                .Where(x => x.ReleaseDate.HasValue && x.ReleaseDate.Value < concrateDate)
                .OrderByDescending(x => x.ReleaseDate)
                .Select(x => new
                {
                    x.Title,
                    x.EditionType,
                    x.Price
                })
                .ToList();

            result.ForEach(x => sb.AppendLine($"{x.Title} - {x.EditionType} - ${x.Price:F2}"));

            return sb.ToString().Trim();
        }

        //07. Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var result = context.Authors
                .Where(x => x.FirstName.EndsWith(input.ToLower()))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                })
                .ToList();

            result.ForEach(x => sb.AppendLine($"{x.FirstName} {x.LastName}"));

            return sb.ToString().Trim();
        }

        //08. Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var result = context.Books
                .Where(x => x.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(x => x.Title)
                .Select(x => x.Title)
                .ToList();

            result.ForEach(x => sb.AppendLine(x));

            return sb.ToString().Trim();
        }

        //09. Book Search by Author
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            var result = context.Books  
                .Where(x => x.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(x => x.BookId)
                .Select(x => new
                {
                    Title = x.Title,
                    AuthorName = $"{x.Author.FirstName} {x.Author.LastName}",
                })
                .ToList();

            foreach (var book in result)
            {
                sb
                    .AppendLine($"{book.Title} ({book.AuthorName})");
            }

            return sb.ToString().Trim();
        }

        //10. Count Books
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {           
            var result = context.Books
                .Where(x => x.Title.Length > lengthCheck)
                .ToList();
            
            return result.Count;
        }

        //11. Total Book Copies
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();

            var result = context.Authors
                .Select(x => new
                {
                    AuthorName = x.FirstName + " " + x.LastName,
                    BookCopies = x.Books.Count()
                })
                .ToList();
            
            foreach (var book in result)
            {
                sb
                    .AppendLine($"{book.AuthorName} - {book.BookCopies}");
            }

            return sb.ToString().Trim();
        }

        //12. Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            var result = context.Categories
                .Select(x => new
                {
                    CategoryName = x.Name,
                    CategoryProfit = x.CategoryBooks.Sum(x => x.Book.Price * x.Book.Copies)
                })
                .ToList();

            result = result.OrderByDescending(x => x.CategoryProfit).ThenBy(x => x.CategoryName).ToList();

            result.ForEach(x => sb.AppendLine($"{x.CategoryName} ${x.CategoryProfit:f2}"));

            return sb.ToString().Trim();
        }
    }
}


