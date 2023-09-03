/* int plus1 = 2;
int plus2 = 3;
int total;

total = (plus1 + plus2);
Console.Write(total); */ // ค่าบวก


/* int minus1 = 4;
int minus2 = 2;
int total = minus1-minus2;
Console.Write(total); */    // ค่าลบ


/* int modu1 = 8;
int modu2 = 3;

int total = modu1 % modu2;
Console.Write(total); */    //ค่าหาเศษ


/* int plus = 0;
int total = 0;

plus++;
total = plus;

Console.Write(total); */    //ค่าบวก 1


/* int minus_down = 10;
int total = 0;

minus_down--;
total = minus_down;

Console.Write(total); */    //ค่าลบ 1



/* int min = Math.Min(5,10);
Console.WriteLine(min);       

int max = Math.Max(5,10);
Console.Write(max); */     // ค่าน้อยกับค่ามาก


/* string hello = "Hello";
string world = "World";
Console.WriteLine(hello+" "+world); */  //แสดงผลลัพธ์


/* bool val = false;
bool check = false;
Console.WriteLine(val==check); */       // ใช่หรือไม่


 /*int input;

Console.Write("Input Value: ");   
input = Int32.Parse(Console.ReadLine());


if (input == 2)
{
    Console.WriteLine("True Success");
}

else if (input == 3)
{
    Console.WriteLine("Yes this is 3 value Success");
}

else if (input == 4)
{
    Console.WriteLine("Yes this is 4 value Success");
}

else if (input == 5)
{
    Console.WriteLine("Yes this is 5 value Success");
}

else if(input == 6 || input == 12)
{
    Console.WriteLine("Yes this is 6 or 12 value Success");
}

else
{
    Console.WriteLine("False");                 // IF-Else
} */



/*int day = 2;

switch (day) 
{
    case 1:
    Console.WriteLine("Monday");
    break;
  
    case 2:
    Console.WriteLine("Tuesday");
    break;
  
    case 3:
    Console.WriteLine("Wednesday");
    break;
  
    case 4:
    Console.WriteLine("Thursday");
    break;
  
    case 5:
    Console.WriteLine("Friday");
    break;
  
    case 6:
    Console.WriteLine("Saturday");
    break;

    case 7:
    Console.WriteLine("Sunday");
    break;

    default:
    Console.WriteLine("Not True");
    break;
} */



string[] cars = {"Volvo", "BMW", "Ford", "Mazda"
                ,"Honda","Tesla","Nissan","Lambogini"};

string[] color = {"Red", "Blue", "Black", "White"
                ,"Green","Purple","Brown","Yellow"};


int i = 0;
int seq = 0;
while (i < 8) 
{

    seq++;
  Console.WriteLine(seq+"."+cars[i]+" "+"Color is "+color);
  i++;
}



