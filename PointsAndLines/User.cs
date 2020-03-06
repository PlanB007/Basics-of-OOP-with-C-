namespace PointAndLines
{
    class User 
    {

        public static int currentID;
        public readonly int ID; 
        public readonly int HEIGHT;
        public Race race;
        private string username;
        private int password;

        public string Username 
        { 
            get 
            {
                return "Username: " + username;
            } 
             
        }

        public int Password 
        { 
            set
            {
                if(value >= 4 && value <= 10) 
                {
                    password = value;
                }
                else 
                {
                    System.Console.WriteLine("Invalid password");
                }
            } 
        
        }

        public User() {
            currentID++;
            ID = currentID;
        }

        public User(string username, Race race) 
        {
            currentID++;
            ID = currentID;
            this.username = username;
            this.race = race;

            if (this.race == Race.Marsian)
            {
                HEIGHT = 100;
            }
            else if (this.race == Race.Earthling)
            {
                HEIGHT = 180;
            }
        }
        public void SayMyName()
        {
            Utilites.ColorFullWriteLine(this.username, System.ConsoleColor.DarkGreen);        
        }
    }
}

