namespace StreetLights
{
    using System; 
    public class Program 
    {
        public static int Streets_Left = 5;
        public static void Main (string[] args)
        {
            //Introduction to the code// 

            TypeEffect("Welcome to my code\nIn this code, you will try to cross the street\nSo easy right?\nWell let's get started.");

            //User introduction//
            TypeEffect("First of all, what is your name?");
            string name = Console.ReadLine()!;

            //Code elements//
            List<string> lights = new List<string>();
            lights.Add("green");
            lights.Add("red");
            lights.Add("yellow");
            string Ans = "";

            //Challenge//
            TypeEffect("Welcome!! " + name + " you are in a life or death situation\nIn front of you, you can see some street lights");

            //First loop// 
            while (true)
            {
                TypeEffect("The light is " + lights[0] + " but it's raining so bad\nDo you want to try to cross the street?");
                Ans = Console.ReadLine()!.ToUpper(); // I put ! because it gave me a null warning //
                //ToUpper turns the user input to UPPERCASE so that it fits in the loop//
                if (Ans == "NO")
                {
                    Streets_Left--; //This indicates the amount of questions left//
                    TypeEffect("Congrats! You survived the first street\nYou have " + Streets_Left + " streets left");
                    break;
                }
                else if (Ans == "YES")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No");
            }
            
            //Next loop//
            while(true)
            {
                TypeEffect("Now the light is " + lights[1] + " but there are no cars coming your way\nDo you want to try to cross the street?");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "NO")
                {
                    Streets_Left--;
                    TypeEffect("You are doing great! Respected the law and got a 100€ reward\nYou have " + Streets_Left + " streets left");
                    break;
                }
                else if (Ans == "YES")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No");
            }

            //Next loop//
            while(true)
            {
                TypeEffect("Now the light is "+ lights[0] + " and no cars coming your way\nDo you want to try to cross the street?");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "YES")
                {
                    Streets_Left--;
                    TypeEffect("That was easy right? Keep going!\nYou have " + Streets_Left + " streets left");
                    break;
                }
                else if (Ans == "NO")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No");
            }

            //Next loop//
            while(true)
            {
                TypeEffect("In this street there are no lights, good luck\nNo cars on the right...\nThere's a car out of control coming right at you from the left\nDo you want to cross the street?");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "YES")
                {
                    Streets_Left--;
                    TypeEffect("You dodged the car. Nice!\nYou have " + Streets_Left + " street left");
                    break;
                }
                else if (Ans == "NO")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No");
            }

            //Last loop//
            while(true)
            {
                TypeEffect("Now the light is " + lights[2] + " but there is a car coming at you from the right\nDo you want to cross the street?");
                Ans = Console.ReadLine()!.ToUpper();
                if (Ans == "YES")
                {
                    Streets_Left--;
                    TypeEffect("You almost got hit by the car but got to the other side\nNice job, now you are at you destination with an extra 100€ in your pocket");
                    break;
                }
                else if (Ans == "NO")
                {
                    DIE();
                }
                TypeEffect("You have to answer Yes or No");
            }
             
        }

        //Method DIE//
        public static void DIE()
        {
            if (Streets_Left == 5)
            {
                TypeEffect("Great! You slipped and hit your head very hard\nTry Again.");
            }
            else if(Streets_Left == 4)
            {
                TypeEffect("WRONG! You broke the law and now you are being chased by the police.\nTry Again");
            }
            else if(Streets_Left == 3)
            {
                TypeEffect("You waited too long and someone stole your 100€\nTry Again.");
            }
            else if(Streets_Left == 2)
            {
                TypeEffect("You waited too long and got ran over\nTry Again.");
            }
            else if(Streets_Left == 1)
            {
                TypeEffect("You never got to your destination\nTry Again.");
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
            Console.WriteLine();
        }

    }
}
