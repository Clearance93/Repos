
namespace PointAndLines
{
    class User
    {
        public readonly int HEIGHT;

        public static int currentID;

        public int id;

        public Race race;

        private string username;
        private int password;


        public string Username 
        { 
            get
            {
                return username; 
            }
        }

        public int Password 
        {
           
            set
            {
                if (value > 4 && value < 10)
                {
                    password = value;
                }
                else
                {
                    System.Console.WriteLine("Oops, this is not a valid password! please use an password between 4 and 10 numbers!");
                }
            }
        }

        public User()
        {
            User.currentID++;
            id = currentID;
        }

        public User(string username, Race race)
        {
            currentID++;
            id = currentID;
            this.username = username;
            this.race = race;


            if(this.race == Race.Marsian)
            {
                HEIGHT = 100;
            }
            else if(this.race == Race.Earthing)
            {
                HEIGHT = 180;
            }
        }
    }

}