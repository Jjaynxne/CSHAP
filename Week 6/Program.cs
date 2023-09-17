int loop =0;                //วน 3 รอบ

Console.Write("How many record here: ");
loop = Int32.Parse(Console.ReadLine());


string std , prefix , fname , lname , score;

string[][] data = new string[loop][];
string grade;
int point;

    // วนรูบ เก็บข้อมูล
for(int i=0; i<loop; i++){
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
        Console.WriteLine(" ");

    //วนรูบ แสดงข้อมูล
    Console.WriteLine("_________________________________");
    Console.WriteLine(" ");

  for(int i=0; i<loop; i++){

        point = Int32.Parse(data[i][4]);
        if (point >= 80)
        {
            grade = "A";
        }

        else if (point >= 75)
        {
            grade = "B+";
        }
        else if (point >= 70)
        {
            grade = "B";
        }
        else if (point >= 65)
        {
            grade = "C+";
        }
        else if (point >= 60)
        {
            grade = "C";
        }
        else if (point >= 55)
        {
            grade = "D+";
        }
        else if (point >= 50)
        {
            grade = "D";
        }
        else if (point == 0)
        {
            grade = "I";
        }

         else
        {
            grade = "E";
        }

        Console.WriteLine("Student ID: "+data[i][0]+" , Fullname : "+
        data[i][1]+
        data[i][2]+" "+
        data[i][3]+
        " , Grade: "+grade
        );
  }  
    Console.WriteLine("_________________________________");

