string prefix = "";
string fname = "";
string lname = "";
int     ID = 0;
double height = 0;
double weight = 0.0D;
double BMI = 0.0D;


Console.Write("Input Prefix: ");   
prefix = Console.ReadLine();

Console.Write("Input First name: ");   
fname = Console.ReadLine();

Console.Write("Input Last name: ");  
lname = Console.ReadLine();

Console.Write("Input Student ID: ");   
ID = Int32.Parse(Console.ReadLine());

Console.Write("Input Height: ");        
height = double.Parse(Console.ReadLine());

Console.Write("Input Weight: ");        
weight = double.Parse(Console.ReadLine());

BMI = height/weight;
BMI = Math.Pow(BMI, 2);

Console.WriteLine("********************");
Console.WriteLine("Student ID: "+ID);
Console.WriteLine("Fullname is: "+prefix+fname+" "+lname);
Console.WriteLine("Your Heigt is: "+height);
Console.WriteLine("Your Weight is: "+weight);
Console.WriteLine("BMI is: "+BMI);
Console.WriteLine("********************");  