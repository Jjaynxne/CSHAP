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
            //ตัดเกรด
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
                grade_is = "i";
            }
            else
            {
                grade_is = "E";
            }

        }
        static void Main(string[] args)
        {

            int loop = 0;


            Console.Write("How many record input :");   
            loop = Int32.Parse(Console.ReadLine());      



            string student_id, prefix, fname, lname, gpa;

            string[][] data = new string[loop][];


            string grade;
            int point;


            
            for (int i = 0; i < loop; i++)
            {
                Console.Write("input student ID :");
                student_id = Console.ReadLine();

                Console.Write("input prefix :");
                prefix = Console.ReadLine();

                Console.Write("input first name :");
                fname = Console.ReadLine();

                Console.Write("input last name :");
                lname = Console.ReadLine();

                Console.Write("input score :");
                gpa = Console.ReadLine();

                Console.WriteLine("______________________________________________________________");

                
                data[i] = new string[] { student_id, prefix, fname, lname, gpa };



            }
            for (int i = 0; i < loop; i++)
            {
                Grade score = new Grade(Int32.Parse(data[i][4]));
                Console.WriteLine("ID : " + data[i][0]);
                Console.WriteLine("Full Name : " + data[i][1] + data[i][2] +"  "+ data[i][3] );
                Console.WriteLine("Your grade : " + score.grade_is );
            }
        }

    }
}