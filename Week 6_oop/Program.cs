using System;
namespace Program
{

    class Grade
    { 

        public string grade_is;
        
            public Grade(int score)
            {
                int point;
                point = score;

                if (point >= 80)
                {
                grade_is = "A";
                }

                else if (point >= 75)
                {
                grade_is = "B+";
                }

                else if (point >= 70)
                {
                grade_is = "B";
                }
            
                else if (point >= 65)
                {
                grade_is = "C+";
                }

                else if (point >= 60)
                {
                grade_is = "C";
                }

                else if (point >= 55)
                {
                grade_is = "D+";
                }

                else if (point >= 50)
                {
                grade_is = "D";
                }

                else if (point == 0)
                {
                grade_is = "I";
                }

                else
                {
                grade_is = "E";
                }
            
            }
   
            // Function หลัก Object || Function
        
            static void Main(string[] args)
            {
                    int loop =0;                //วน 3 รอบ

                    Console.Write("How many record here: ");
                    loop = Int32.Parse(Console.ReadLine());

                    string std , prefix , fname , lname , score;

                    string[][] data = new string[loop][];
                    string grade;
                    int point;

                        // วนรูบ เก็บข้อมูล
                    for(int i=0; i<loop; i++)
                    {

                        Console.Write("Input Student ID: ");
                        std = Console.ReadLine();

                        Console.Write("Input Prefix: ");
                        prefix = Console.ReadLine();

                        Console.Write("Input First Name: ");
                        fname = Console.ReadLine();

                        Console.Write("Input Last Name: ");
                        lname = Console.ReadLine();

                        Console.Write("Input Score: ");
                        score = Console.ReadLine();

                        Console.WriteLine("_________________________________");

                            // Save to Data
                        data[i] = new string[] {std,prefix,fname,lname,score};
                    }

                    for(int i = 0; i < loop; i++)
                        {
                            Grade score = new Grade(Int32.Parse(data)[i][4]);
                            Console.WriteLine("Student ID: "+data[i][0]+" , Fullname : "+
                            data[i][1]+
                            data[i][2]+" "+
                            data[i][3]+
                            " , Grade: "+score.grade_is
                            );
                        }

            }

    }

}



