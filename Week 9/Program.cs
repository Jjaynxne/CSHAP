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
                CoffeePremuim MN = new CoffeePremuim();
                switch (val)
                {
                    
                    case 1:
                    {
                        MN.amazon();
                        break;
                    }

                    case 2:
                    {
                        MN.inthanin();
                        break;
                    }

                    case 3:
                    {
                        MN.punthai();
                        break;
                    }

                    case 4:
                    {
                        MN.doro();
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
                Console.WriteLine("++++++   - BLACK COFFEE         ++++++");
                Console.WriteLine("++++++   - CAPPUCHINO           ++++++");
                Console.WriteLine("++++++   - LATE                 ++++++");
            }


        public void inthanin()
            {
                Console.WriteLine("++++++ WELCOME TO INTHANIN CAFE ++++++");
                Console.WriteLine("++++++           MENU           ++++++");
                Console.WriteLine("++++++   - BLACK MIX ORANGE     ++++++");
                Console.WriteLine("++++++   - LATE                 ++++++");
                Console.WriteLine("++++++   - CAPPUCHINO           ++++++");
            }


        public void punthai()
            {
                Console.WriteLine("++++++ WELCOME TO PUNTHAI CAFE ++++++");
                Console.WriteLine("++++++           MENU         ++++++");
                Console.WriteLine("++++++ - CHOCOLATE MILK       ++++++");
                Console.WriteLine("++++++ - AMERICANO            ++++++");
            }


        public void doro()
            {
                Console.WriteLine("++++++ WELCOME TO O-DRO CAFE ++++++");
                Console.WriteLine("++++++           MENU        ++++++");
                Console.WriteLine("++++++   - MILK CHOCOLATE    ++++++");
                Console.WriteLine("++++++   - CAPPUCHINO        ++++++");
            }


    }

}