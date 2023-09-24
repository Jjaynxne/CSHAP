using System;
namespace Program
{

    class Finance
    {  
        public static void Main(string[] args)
            {
                int product_num = 0; // จำนวนสินค้า
                string code , product_name , price;
                    // จำนวนสินค้า
                    Console.Write("Number of Products : ");
                    product_num = Int32.Parse(Console.ReadLine()); // แปลง String เป็น Int
                    
                    string [][]product_data = new string [product_num][];

                    // เก็บข้อมูลสินค้า
                    for(int i = 0; i < product_num; i++)
                        {
                            Console.WriteLine(" ");

                            Console.Write("Input Product Code : ");
                            code = Console.ReadLine();

                            Console.Write("Input Product Name : ");
                            product_name = Console.ReadLine();

                            Console.Write("Input Price : ");
                            price = Console.ReadLine();

                            Console.WriteLine("__________________________________________");
                            product_data[i] = new string []{code, product_name, price};
                        }
                    

                        // STEP 3
                     Console.WriteLine();
                     Console.WriteLine(" ============ JAYNXNE MART ============ ");
                     Console.WriteLine("___________________________________________");
                     Console.WriteLine(" #Title  (Code)                  PRICE ");
                     Console.WriteLine("___________________________________________");
                        

                        //VARIABLE                                   สูตร ภาษี
                        double product_price = 0.00 ,vat = 0.00 , val = 107, total = 0.00;


                        // STEP 2 DATA PRODUCT
                        for(int i = 0; i < product_num; i++)
                        {
                            
                            Console.WriteLine
                            (
                                (i+1)+"  "+
                                product_data[i][1]+"      "+
                                product_data[i][0]+"               "+"   "+
                                product_data[i][2]+"               "                           
                            );

                                // เก็บราคาสินค้า
                                total += double.Parse(product_data[i][2]);

                        }

                        vat = Math.Round((total*7)/val, 2);
                        total = total;
                        product_price = total - vat;

                     Console.WriteLine("___________________________________________");
                     Console.WriteLine(" Product Price                      "+product_price);
                     Console.WriteLine(" Vat                                "+vat);
                     Console.WriteLine(" Total                              "+total);
                     Console.WriteLine("___________________________________________");
                     Console.WriteLine();
                     Console.WriteLine(" *_* THANK YOU *_* ");
                     

            }
    }

}
