namespace ManyToMany
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new StudentsDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}
