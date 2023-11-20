using HospitalDatabase.Data;

namespace HospitalDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new HospitalDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}