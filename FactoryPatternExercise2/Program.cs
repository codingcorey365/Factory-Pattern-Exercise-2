using System.Threading.Channels;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool correctInput = true;
            do  // if satement
            {   // if satement
                Console.WriteLine("Hello, what type of database would you like to use? Enter: list, sql or mongo for the database type you would like to utilize.");

                string databaseType = Console.ReadLine();

                // ---------------------------------------  If Else Statement ---------------------------------------------------
                // Console.WriteLine("-------------------------------------------------------------------------------------------");
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
                // Console.WriteLine("-------------------------------------------------------------------------------------------");

                // ---------------------------------------  Switch Case Statement -----------------------------------------------
                // Console.WriteLine("-------------------------------------------------------------------------------------------");
                //switch (databaseType.ToLower())
                //{
                //    case "list":
                //        break;
                //    case "sql":
                //        break;
                //    case "mongo":
                //        break;
                //    default:
                //        Console.WriteLine("Invalid input. Please enter: list, sql, or mongo for the database type you would like to utilize.");
                //        correctInput = false;
                //        break;
                //}

                //IDataAccess database = DataAccessFactory.GetDataAccessType(databaseType);

                //List<Product> products = database.LoadData();
                //database.SaveData();

                //foreach (var item in products)
                //{
                //    Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
                //}
                // Console.WriteLine("-------------------------------------------------------------------------------------------");

            } while (correctInput == false); // if satement
        }
    }
}
