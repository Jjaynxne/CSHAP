using System;

public class Program
{
    public static void Main()
    {
        GEAR_KUB g = new GEAR_KUB();
        g.Main_Choice();
    }
}

class GEAR_KUB
{
    public string g_name;
    public string g_brand;
    

    
    public void Main_Choice()
    {
        GEAR_KUB g = new GEAR_KUB();
        Console.WriteLine("----------    Welcome To JAYNxNE GEAR-KUB    ----------");
        Console.WriteLine("----------        1. Screen Products         ----------");
        Console.WriteLine("----------        2. KeyBoard Products       ----------");
        Console.WriteLine("----------        3. Mouse Products          ----------");
        Console.WriteLine("----------        4. Earphones Products      ----------");
        Console.WriteLine("----------        5. Speakers Products       ----------");
        Console.WriteLine("----------        6. ETC. Products           ----------");
        Console.WriteLine("-------------------------------------------------------");
        Console.Write(" Selected Yours Choice : ");
        string user_choice = Console.ReadLine().ToUpper();
        Console.WriteLine(" ------------------------------------ ");
        g.Another(user_choice);
    }

    public void Another(string choice)
    {
        GEAR_KUB g = new GEAR_KUB();

        if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6")
        {
            g.G_Gear(Int32.Parse(choice));
            g.G_Brand();
        }

        else
        {
            Console.WriteLine("");
            Console.WriteLine(" ---------------------------------- ");
            Console.WriteLine(" WRONG CHOICE ");
            Console.WriteLine(" ---------------------------------- ");
            Console.Write("EXIT (Y/N): ");
            string notfound = Console.ReadLine().ToUpper();  
            
            if (notfound == "Y")
            {
                
            }
            else if (notfound == "N")
            {
              g.Main_Choice();
            }
        }
    }

    public void G_Brand()
    {
        GEAR_KUB g = new GEAR_KUB();
        Console.WriteLine("");
        Console.WriteLine("--------    JAYNxNE GEAR-KUB    --------");
        Console.WriteLine("---- Your Selected: {0} ----", g_name);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("--------         Brands         --------");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("--------      1. Logitech       --------");
        Console.WriteLine("--------      2. Razer          --------");
        Console.WriteLine("--------      3. Cosair         --------");
        Console.WriteLine("--------      4. Hyper X        --------");
        Console.WriteLine("--------      5. Steel Series   --------");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("---- Q = Exit, H = Back To Menu ----");
        Console.WriteLine(" ----------------------------------------");
        Console.Write(" Selected Brand: ");
        string brand = Console.ReadLine().ToUpper();
        Console.WriteLine(" ---------------------------------- ");

        if (brand == "1" || brand == "2" || brand == "3" || 
            brand == "4" || brand == "5")
        {
            g.G_BrandName(Int32.Parse(brand), g_name);
            g.Finish();
        }
        else
        {
            g.Another(null);
        }
    }

    public void Choose_Brand()
    {
        GEAR_KUB g = new GEAR_KUB();



    }




    public void G_Gear(int g_gear)
    {
        switch (g_gear)
        {
            case 1:
            {
                g_name = "Screen Products";
                break;
            }
                
            case 2:
            {
                g_name = "Keyboard Products";
                break;
            }
                
            case 3:
            {
                g_name = "Mouse Products";
                break;
            }

            case 4:
            {
                g_name = "Earphone Products";
                break;
            }
                
            case 5:
            {
                g_name = "Speaker Products";
                break;
            }
                
            case 6:
            {
                g_name = "ETC. Products";
                break;
            }
               
        }
    }

    public void G_BrandName(int g_brands, string g_names)
    {
        g_name = g_names;
        switch (g_brands)
        {
            case 1:
            {
                g_brand = "Logitech";
                break;
            }
                
            case 2:
            {
                g_brand = "Razer";
                break;
            }
                
            case 3:
            {
                g_brand = "Corsair";
                break;
            }

            case 4:
            {
                g_brand = "Hyper X";
                break;
            }
                
            case 5:
            {
                g_brand = "Steel Series";
                break;
            }
                
                
        }
    }

    public void Finish()
    {
        Console.WriteLine("");
        Console.WriteLine("------  THIS IS YOUR PROGRAM  ------");
        Console.WriteLine("     Your Movie : {0} ", g_name);
        Console.WriteLine(" Your Round Times : {0} ", g_brand);
        Console.WriteLine("------        Thank YOU       ------");
        Console.WriteLine("------       PLEASE ENJOY     ------");
        Console.WriteLine("------ THANK FOR YOUR SUPPORT ------");
        Console.WriteLine("");
    }


}