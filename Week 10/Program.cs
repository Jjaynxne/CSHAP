using System;
namespace Program
{

    class CoffeeLuxer
    {

    }

    class CoffeePremuim
    {

        public static void Main(string[] args)
        {
            
            int val;
            CoffeePremuim CP = new CoffeePremuim();
            CP.selected_band();
            val = Int32.Parse(Console.ReadLine());
            CP.Lines();
            CP.routes(val);

                // เลือก Menu ของ Brand

        }
            public void routes(int val)
            {
                CoffeePremuim CP = new CoffeePremuim();
                int menu;

                switch (val)
                {
                    
                    case 1:
                    {
                        CP.amazon();
                        Console.Write("Choose Your Drink: "); 
                        menu = Int32.Parse(Console.ReadLine());
                        CP.amazon_menu(menu);   
                        break;
                    }

                    case 2:
                    {
                        CP.inthanin();
                        Console.Write("Choose Your Drink: "); 
                        menu = Int32.Parse(Console.ReadLine());
                        CP.inthanin_menu(menu);  
                        break;
                    }

                    case 3:
                    {
                        CP.punthai();
                        Console.Write("Choose Your Drink: "); 
                        menu = Int32.Parse(Console.ReadLine());
                        CP.punthai_menu(menu);
                        break;
                    }

                    case 4:
                    {
                        CP.doro();
                        Console.Write("Choose Your Drink: "); 
                        menu = Int32.Parse(Console.ReadLine());
                        CP.doro_menu(menu); 
                        break;
                    }

                    default:
                    {
                        break;
                    }

                }

            }  



            public void Lines()
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(" ");
            }

              

        public void selected_band()
            {
                
                Console.WriteLine("------   Selected Brand Coffee  ------");
                Console.WriteLine("------       1 : Amezon         ------");
                Console.WriteLine("------       2 : INTHANIN       ------");
                Console.WriteLine("------       3 : PUNTHAI        ------");
                Console.WriteLine("------       4 : D-ORO          ------");
                Console.WriteLine("");
                Console.Write("Plese Selected : ");  
                         
            }


        public void amazon()
            {
                Console.WriteLine("++++++ WELCOME TO AMAZON CAFE   ++++++");
                Console.WriteLine("++++++           MENU           ++++++");
                Console.WriteLine("++++++   1. BLACK COFFEE         ++++++");
                Console.WriteLine("++++++   2. CAPPUCHINO           ++++++");
                Console.WriteLine("++++++   3. LATE                 ++++++");
                Console.WriteLine("");

            }


            public void amazon_menu(int menu)  
        {
                switch (menu)
                {
                     case 1:
                    {
                        Console.WriteLine(" You Choose Black COFFEE is 50 BATH ");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine(" You Choose CAPPUCHINO is 45 BATH ");
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine(" You Choose LATE is 50 BATH");
                        break;
                    }   
                }
        }



        public void inthanin()
            {
                Console.WriteLine("++++++ WELCOME TO INTHANIN CAFE ++++++");
                Console.WriteLine("++++++           MENU           ++++++");
                Console.WriteLine("++++++   - BLACK MIX ORANGE     ++++++");
                Console.WriteLine("++++++   - LATE                 ++++++");
                Console.WriteLine("++++++   - CAPPUCHINO           ++++++");
            }

public void inthanin_menu(int menu)  
        {
                switch (menu)
                {
                     case 1:
                    {
                        Console.WriteLine(" You Choose Black MIX COFFEE is 50 BATH ");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine(" You Choose LATE is 50 BATH ");
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine(" You Choose CAPPUCHINO is 50 BATH ");
                        break;
                    }   
                }
        }


        public void punthai()
            {
                Console.WriteLine("++++++ WELCOME TO PUNTHAI CAFE ++++++");
                Console.WriteLine("++++++           MENU         ++++++");
                Console.WriteLine("++++++ - CHOCOLATE MILK       ++++++");
                Console.WriteLine("++++++ - AMERICANO            ++++++");
            }

        public void punthai_menu(int menu)  
        {
                switch (menu)
                {
                     case 1:
                    {
                        Console.WriteLine(" You Choose CHOCOLATE MILK is 55 BATH ");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine(" You Choose AMERICANO is 50 BATH ");
                        break;
                    }
                 
                }
        }            


        public void doro()
            {
                Console.WriteLine("++++++ WELCOME TO O-DRO CAFE ++++++");
                Console.WriteLine("++++++           MENU        ++++++");
                Console.WriteLine("++++++   - MILK CHOCOLATE    ++++++");
                Console.WriteLine("++++++   - CAPPUCHINO        ++++++");
            }

            public void doro_menu(int menu)  
        {
                switch (menu)
                {
                     case 1:
                    {
                        Console.WriteLine(" You Choose MILK CHOCOLATE is 55 BATH ");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine(" You Choose CAPPUCHINO is 50 BATH ");
                        break;
                    }
 
                }
        }


    }

}