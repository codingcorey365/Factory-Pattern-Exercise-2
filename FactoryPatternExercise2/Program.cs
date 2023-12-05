using System.Threading.Channels;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what type of database would you like to use? Enter: list, sql or mongo for the database type you would like to utilize.");

            string databaseType = Console.ReadLine();
            bool correctInput = true;
            //do
            //{

            //} while (correctInput = false);
            if (databaseType == "list".ToLower() || databaseType == "sql".ToLower() || databaseType == "mongo".ToLower())
            {
                IDataAccess database = DataAccessFactory.GetDataAccessType(databaseType);

                List<Product> products = database.LoadData();
                database.SaveData();

                foreach (var item in products)
                {
                    Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
                }
            }
            else
            {
                Console.WriteLine("Not a valid input");
                correctInput = false;
            }
        }
    }
}
