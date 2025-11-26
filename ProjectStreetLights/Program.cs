namespace StreetLights
{

    public class Program 
    {
        public static int Streets_Left = 5;
        public static void Main (string[] args)
        {
            //Introduction to the code// 

            TypeEffect("Welcome to my code\nIn this code, you will try to cross the street\nSo easy right?\nWell let's get started.");

            //User introduction//
            TypeEffect("First of all, what is your ");
            TypeEffect("name?", ConsoleColor.Yellow);
            Console.WriteLine();
            string name = Console.ReadLine()!;

            //Code elements//
            List<string> lights = new List<string>();
            lights.Add("green");
            lights.Add("red");
            lights.Add("yellow");
            string Ans = "";

            //Challenge//
            TypeEffect("Welcome!! ");
            TypeEffect(name, ConsoleColor.Yellow);
            TypeEffect(" you are in a life or death situation\nIn front of you, you can see some street lights");
            Console.WriteLine();

            //First loop// 
            while (true)
            {
                TypeEffect("The light is ");
                TypeEffect(lights[0], ConsoleColor.Green);
                //Here I star using the elements of the list above//
                TypeEffect(" but it's raining so bad\nDo you want to try to cross the street?\n");
                Ans = Console.ReadLine()!.ToUpper();  
                // I put ! because it gave me a null warning //
                //ToUpper turns the user input to UPPERCASE so that it fits in the loop//
                if (Ans == "NO")
                {
                    Streets_Left--; //This indicates the amount of questions left//
                    Console.ForegroundColor = ConsoleColor.Yellow;//Console color to add format to the text//
                    TypeEffect("Congrats! You survived the first street\nYou have " + Streets_Left + " streets left\n");
                    Console.ResetColor();
                    break;
                }
                else if (Ans == "YES")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No\n");
            }
            
            //Next loop//
            while(true)
            {
                TypeEffect("Now the light is ");
                TypeEffect(lights[1],ConsoleColor.Red);
                TypeEffect(" but there are no cars coming your way\nDo you want to try to cross the street?\n");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "NO")
                {
                    Streets_Left--;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect("You are doing great! Respected the law and got a 100€ reward\nYou have " + Streets_Left + " streets left\n");
                    Console.ResetColor();
                    break;
                }
                else if (Ans == "YES")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No\n");
            }

            //Next loop//
            while(true)
            {
                TypeEffect("Now the light is ");
                TypeEffect(lights[0], ConsoleColor.Green);
                TypeEffect(" and no cars coming your way\nDo you want to try to cross the street?\n");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "YES")
                {
                    Streets_Left--;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect("That was easy right? Keep going!\nYou have " + Streets_Left + " streets left\n");
                    Console.ResetColor();
                    break;
                }
                else if (Ans == "NO")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No\n");
            }

            //Next loop//
            while(true)
            {
                TypeEffect("In this street there are no lights, good luck\nNo cars on the right...\nThere's a car out of control coming right at you from the left\nDo you want to cross the street?\n");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "YES")
                {
                    Streets_Left--;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect("You dodged the car. Nice!\nYou have " + Streets_Left + " street left\n");
                    Console.ResetColor();
                    break;
                }
                else if (Ans == "NO")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No\n");
            }

            //Last loop//
            while(true)
            {
                TypeEffect("Now the light is ");
                TypeEffect(lights[2], ConsoleColor.Yellow);
                TypeEffect(" but there is a car coming at you from the right\nDo you want to cross the street?\n");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "YES")
                {
                    Streets_Left--;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect("You almost got hit by the car but got to the other side\nNice job, now you are at you destination with an extra 100€ in your pocket\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("  WIN  ");
                    Console.ResetColor();
                    break;
                }
                else if (Ans == "NO")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No\n");
            }
                    Console.ResetColor();

        }

        //Method DIE//
        public static void DIE()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (Streets_Left == 5)
            {
                TypeEffect("Great! You slipped and hit your head very hard\nTry Again.\n");
                Console.ResetColor();
            }
            else if(Streets_Left == 4)
            {
                TypeEffect("WRONG! You broke the law and now you are being chased by the police.\nTry Again.\n");
                Console.ResetColor();
            }
            else if(Streets_Left == 3)
            {
                TypeEffect("You waited too long and someone stole your 100€\nTry Again.\n");
                Console.ResetColor();
            }
            else if(Streets_Left == 2)
            {
                TypeEffect("You waited too long and got ran over\nTry Again.\n");
                Console.ResetColor();
            }
            else if(Streets_Left == 1)
            {
                TypeEffect("You never got to your destination\nTry Again.\n");
                Console.ResetColor();
            }   
        }
        
        //Method TypeEffect//
        public static void TypeEffect(string text, int delay = 25)
        {
            foreach(char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

        //Method for color//
        public static void TypeEffect(string text, ConsoleColor color, int delay = 25)
        {
            Console.ForegroundColor = color;
            foreach(char c in text)
            {
                Console.Write(c);
            }
            Console.ResetColor();
        }

    }
}
