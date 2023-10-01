using System;
namespace Program
{

    class Variable
    {  
        public static void Main(string[] args)
            {
                
                int product = 0; 
                string p_name , price;   
                    Console.Write("How many Products : ");
                    product = Int32.Parse(Console.ReadLine()); 
                    
                    string [][]product_data = new string [product][];

                    
                    for(int i = 0; i < product; i++)
                        {
                            Console.WriteLine(" ");

                            Console.Write(" Product Name : ");
                            p_name = Console.ReadLine();

                            Console.Write(" Product Price : ");
                            price = Console.ReadLine();

                            Console.WriteLine("-------------------------------------------------");
                            product_data[i] = new string []{p_name, price};
                        }    
                                
                                double money = 0,tax = 0.00,vat = 0.00,val = 0.00,dis = 0,product_price = 0;
                                double total = 0.00, change = 0.00;

                                Console.WriteLine(" ");

                                Console.Write(" Get the Money : ");
                                 money = Int32.Parse(Console.ReadLine());

                                Console.Write(" Tax Deducted : ");
                                 vat = Int32.Parse(Console.ReadLine());
                                Console.Write(" Discount (Bath) : ");
                                 dis = Int32.Parse(Console.ReadLine());

                                    val = (vat+100);

                                Console.WriteLine("-------------------------------------------------");



                            Console.WriteLine("---------- Welcome to Star Bird Coffee ----------");
                            Console.WriteLine(" No.               Product               Price ");
                            Console.WriteLine("-------------------------------------------------");

                            for(int i = 0; i < product; i++)
                            {
                            
                                Console.WriteLine
                                (

                                (i+1)+"               "+" "+
                                product_data[i][0]+"                "+"   "+
                                product_data[i][1]
                                                           
                                );
                                product_price += double.Parse(product_data[i][1]);
                             }
                                   
                                    tax = Math.Round((product_price*vat)/val,2);
                                    total = (product_price - dis);
                                    change = (money - total);

                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine(" Product Price         "+product_price+" "+"Bath");
                                    Console.WriteLine(" Tax                   "+tax+" "+"Bath");
                                    Console.WriteLine(" Discount              "+dis+" "+"Bath");
                                    Console.WriteLine(" Total                 "+total+" "+"Bath");
                                    Console.WriteLine("-----------------------------------------");
                                    Console.WriteLine(" ");
                                    Console.WriteLine(" Get Money             "+money+" "+"Bath");
                                    Console.WriteLine(" Change                "+change+" "+"Bath");





                        


            }


    }


}   








/*double money = 0 , tax = 5 , dis = 0;
                        price[i] = money;

                         for(int i = 0; i < money; i++)
                        {
                            Console.WriteLine("-------------------------------------------------");

                            Console.Write(" Get The Money: ");
                            money = Console.ReadLine();

                            Console.Write(" Tax Deducted: ");
                            tax = Console.ReadLine();

                            Console.Write(" Discount (Bath) : ");
                            dis = Console.ReadLine();

                            Console.WriteLine("-------------------------------------------------");
                            product_data[i] = new string []{money, tax, dis};
                        }  */