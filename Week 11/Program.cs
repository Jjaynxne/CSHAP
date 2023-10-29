﻿using System;

public class Program
{
    public static void Main()
    {
        Movie m = new Movie();
        m.MainMenu();
    }
}

class Movie
{
    public string movie_name;
    public string movie_time;
    
    public void MainMenu()
    {
        Movie m = new Movie();
        Console.WriteLine("------ Welcome To JAYNxNE Cineplex ------");
        Console.WriteLine("------     Please Selected Movie   ------");
        Console.WriteLine("------          1. Sapalur         ------");
        Console.WriteLine("------          2. The Marvel      ------");
        Console.WriteLine("------          3. TeeYod          ------");
        Console.WriteLine("------        Press Q = Exit      -------");
        Console.WriteLine("-----------------------------------------");
        Console.Write(" Selected Movie : ");
        string user_choice = Console.ReadLine().ToUpper();
        Console.WriteLine(" ------------------------------------ ");
        m.initialChoice(user_choice);
    }

    public void initialChoice(string choice)
    {
        Movie m = new Movie();

        if (choice == "1" || choice == "2" || choice == "3")
        {
            m.getNameMovie(Int32.Parse(choice));
            m.RoundTimes();
        }

        else
        {
            Console.WriteLine("");
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine("The menu you selected was not found.");
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine(" Press Q = Exit, H = Back To Menu ");
            Console.WriteLine("");
            string notfound = Console.ReadLine().ToUpper();
            
            if (notfound == "H")
            {
                m.MainMenu();
            }
            else if (notfound == "Q")
            {
                m.initialChoice("Q");
            }
        }
    }

    public void RoundTimes()
    {
        Movie m = new Movie();
        Console.WriteLine("");
        Console.WriteLine(" --------  JAYNXNE CINEPLEX   ------- ");
        Console.WriteLine(" Your Selected Movie : {0}", movie_name);
        Console.WriteLine(" Please Selected Movie Round Times");
        Console.WriteLine(" ------------------------------------ ");
        Console.WriteLine(" -------   1. 10:00 - 12:00   ------- ");
        Console.WriteLine(" -------   2. 12:00 - 14:00   ------- ");
        Console.WriteLine(" -------   3. 14:00 - 16:00   ------- ");
        Console.WriteLine(" --   Q = Exit, H = Back To Menu  -- ");
        Console.WriteLine(" ------------------------------------ ");
        Console.Write(" Selected TIME TO WATCH : ");
        string user_round = Console.ReadLine().ToUpper();
        Console.WriteLine(" ---------------------------------- ");

        if (user_round == "1" || user_round == "2" || user_round == "3")
        {
            m.getRoundTimes(Int32.Parse(user_round), movie_name);
            m.Finish();
        }
        else
        {
            m.initialChoice(null);
        }
    }

    public void getNameMovie(int movie_id)
    {
        switch (movie_id)
        {
            case 1:
            {
                movie_name = "Sapalur";
                break;
            }
                
            case 2:
            {
                movie_name = "The Marvel";
                break;
            }
                
            case 3:
            {
                movie_name = "TeeYod";
                break;
            }
               
        }
    }

    public void getRoundTimes(int round_time, string watch_name)
    {
        movie_name = watch_name;
        switch (round_time)
        {
            case 1:
            {
                movie_time = "10:00 - 12:00";
                break;
            }
                
            case 2:
            {
                movie_time = "12:00 - 14:00";
                break;
            }
                
            case 3:
            {
                movie_time = "14:00 - 16:00";
                break;
            }
                
        }
    }

    public void Finish()
    {
        Console.WriteLine("");
        Console.WriteLine("------  THIS IS YOUR PROGRAM  ------");
        Console.WriteLine("     Your Movie : {0} ", movie_name);
        Console.WriteLine(" Your Round Times : {0} ", movie_time);
        Console.WriteLine("------        Thank YOU       ------");
        Console.WriteLine("------       PLEASE ENJOY     ------");
        Console.WriteLine("------ THANK FOR YOUR SUPPORT ------");
        Console.WriteLine("");
    }


}