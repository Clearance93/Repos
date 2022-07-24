using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLines;

namespace EntryPoint
{

  

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Clearance", Race.Earthing);
            
            User secondeUser = new User();
            
            User thirdUser = new User();

            Utilities.ColorFulWriteLine(user.Username, ConsoleColor.Red);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(user.id);
            Console.WriteLine(secondeUser.id);
            Console.WriteLine(thirdUser.id);

            Console.WriteLine(User.currentID);

            user.Password = 6;
            System.Console.WriteLine(user.Username);

           
           

            Console.ReadLine();
        }
    }
}
