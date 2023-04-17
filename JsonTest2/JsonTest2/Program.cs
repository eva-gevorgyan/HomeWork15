using Newtonsoft.Json;

namespace JsonTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>() 
            {
               new User("A",24),
               new User("B",14),
               new User("C",29)
           };
            string json = JsonConvert.SerializeObject(users);
            Console.WriteLine(json);
        }
    }
}