using System;
using Newtonsoft.Json;

namespace UseInterfaceToEncryptApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService _service = new UserService();

            var _json = JsonConvert
                            .SerializeObject(_service.GetUsers()
                                , Formatting.Indented);

            Console.WriteLine("User");
            Console.WriteLine("------------------------");
            Console.WriteLine(_json);
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
