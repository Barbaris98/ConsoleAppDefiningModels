using Microsoft.EntityFrameworkCore;

namespace ConsoleAppDefining_Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                db.Database.Migrate();

                Console.WriteLine("Успешно");
                
            }
        }
    }
}