using System;
namespace Program
{

    class Movie
    {
        
        public string movie_name;
        public string round_name;
        
        public void check_state(string choice)
        {
            Movie mv = new Movie();
            
            if(choice == "q")
            {
                Console.Write(" YOUR ARE EXIT ");
            }

            else if(choice == "1" || choice == "2" || choice == "3")
            {
                
                mv.Rounds();
                
            }
            else 
            {
                Console.WriteLine(" PLEASE TRY AGAIN ");
                Console.WriteLine(" ");
                mv.Menu();
            }

        }

        
        public void Menu()
        {
            string choice;
            Console.WriteLine("------ WELCOME TO JAYNXNE CINEPLEX ------");
            Console.WriteLine("------    PLEASE SELECTED MOVIES   ------");
            Console.WriteLine("------         1. SAPALUR          ------");
            Console.WriteLine("------         2. THE MARVEL       ------");
            Console.WriteLine("------         3. TEEYOD           ------");
            Console.WriteLine("------        PRESS q = EXIT       ------");
            Console.WriteLine("-----------------------------------------");
            Console.Write("PLEASE SELECT: ");
            choice = Console.ReadLine();

            movie_name = choice;
            Movie mv = new Movie();
            mv.check_state(choice);

        }
        
        public void check_round(string round)
        {
            Movie mv = new Movie();
            if(round == "q")
            {
                Console.WriteLine(" YOUR ARE EXIT ");
            }
            else if(round == "1" || round == "2" || round == "3")
            {
                mv.Finish();
            }
            
            else if(round == "h")
            {
                Console.WriteLine(" GO TO MAIN ");
                Console.WriteLine("");
                mv.Menu();
            }
            
            else
            {  
                Console.WriteLine(" PLEASE TRY AGAIN ");
                Console.WriteLine(" ");
                mv.Rounds();
            }
        }

        public void Finish()
        {
            Console.WriteLine("Finish");
 
        }


        public void Rounds()
        {
            Movie mv = new Movie();

            Console.WriteLine("------ PLEASE SELECT ROUND ------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("------  1. 10:00 - 12:00   ------");
            Console.WriteLine("------  2. 12:00 - 14:00   ------");
            Console.WriteLine("------  3. 14:00 - 16:00   ------");
            Console.WriteLine("-- PRESS q = exit , h = MAIN --");
            Console.WriteLine("---------------------------------");
            Console.Write("PLEASE SELECT ROUND: ");
            
            string round;
            round = Console.ReadLine();
            mv.check_round(round);
        }

        public static void Main (string[] args)
        {
            
            Movie mv = new Movie();
            mv.Menu();


        }

        

    }



}