string [][] data = new string[10][];

data[0] = new string[] {"654245001","Mr.","Nattapon","Bunrod","75"};
data[1] = new string[] {"654245004","Mr.","Thanawin","Poungsombut","82"};
data[2] = new string[] {"654245005","Mr.","Pludpun","Jamrunrab","56"};
data[3] = new string[] {"654245006","Mr.","Phuri","Prompasert","66"};
data[4] = new string[] {"654245007","Mr.","Phurin","Jitpitipramoth","71"};
data[5] = new string[] {"654245009","Mr.","Sidthipon","Supunnoparb","54"};
data[6] = new string[] {"654245010","Mr.","Anusorn","Garnin","48"};
data[7] = new string[] {"654245011","Mr.","Piwatgittri","Srionrod","79"};
data[8] = new string[] {"654245012","Ms.","Sasigan","Junwan","66"};
data[9] = new string[] {"654245013","Ms.","Thidawan","Chukaram","0"}; 
//int i = 0;

int count; 
int point;
string gpa;

count = data.Length;
Console.WriteLine(count);

for(int i=0; i<count; i++)
{
    point = Int32.Parse(data[i][4]);

        if (point >= 80)
        {
            gpa = "A";
        }

        else if (point >= 75)
        {
            gpa = "B+";
        }
        else if (point >= 70)
        {
            gpa = "B";
        }
        else if (point >= 65)
        {
            gpa = "C+";
        }
        else if (point >= 60)
        {
            gpa = "C";
        }
        else if (point >= 55)
        {
            gpa = "D+";
        }
        else if (point >= 50)
        {
            gpa = "D";
        }
        else if (point == 0)
        {
            gpa = "I";
        }

         else
        {
            gpa = "E";
        }



    Console.WriteLine(
        
            "Student ID is: "+data[i][0]+", "+
            "Fullname is: "+data[i][1]+" "+
            data[i][2]+" "
            +data[i][3]+" "+"Your Grade is: "+" "+
            gpa
                    );

}