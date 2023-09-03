



string[] std = {"663245001", "663245002", "663245003","663245004", 
                "663245005","663245006","663245009","664245025"};

string[] prefix = {"Mr.", "Mr.", "Mr.", "Mr."
                ,"Mr.","Ms.","Mr.","Ms."};

string[] fname = {"Kittiphong", "Tanakorn", "Pongsakon", "Watcharapong"
                ,"Intat","Kannikar","Kitisak","Thanaporn"};

string[] lname = {"Chaimon", "Suphaphut", "Kongnoi", "Maneengam"
                ,"Kanalaksombat","Patposri","Srisuk","Hongngam"};


int i = 0;
int seq = 0;
    
    Console.WriteLine("663245005 Mr.Intat Kanalaksombat");

while (i < 8) 
{

    
    Console.WriteLine(std[i]+" "+prefix[i]+fname[i]+" "+lname[i]);
    seq++;
    i++;
}
