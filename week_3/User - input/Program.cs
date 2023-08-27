//แบบการทำการบ้าน
/*
string fname = " ";
double height = 0.0d;
double weight = 0.0d;
double BMI = 0.0d;

Console.Write ("input first name : ");               //display ชื่อ
fname = Console.ReadLine();                          //input keyboard 

Console.Write ("input height : ");                   //display สูง
height = double.Parse(Console.ReadLine());            //input keyboard and convert

Console.Write ("input weight : ");                   //display น้ำหนัก
weight = double.Parse(Console.ReadLine());           //input keyboard and convert


BMI = height/weight;                                 //หาร
BMI = Math.Pow(BMI,2);                               //การทำเลข ยกกำลัง

Console.WriteLine ("BMI is : " + BMI);               //ค่าดัชนีมวลกาย
*/


//การบ้าน
Console.WriteLine ("Sawasdee Welcome to calculate body mass index");

string ID = " ";
string prefix = " ";
string fname = " ";
string lname = " ";
double height = 0.0d;
double weight = 0.0d;
double BMI = 0.0d;

Console.Write ("Student ID : ");                          //display รหัส
ID = Console.ReadLine();                                  //input keyboard 

Console.Write ("Prefix : ");                              //display คำนำหน้าชื่อ
prefix = Console.ReadLine();                              //input keyboard

Console.Write ("input first name : ");                    //display ชื่อจริง
fname = Console.ReadLine();                               //input keyboard 

Console.Write ("input last name : ");                     //display นามสกุล
lname = Console.ReadLine();                               //input keyboard

Console.Write ("input height : ");                        //display สูง
height = double.Parse(Console.ReadLine());                //input keyboard and convert

Console.Write ("input weight : ");                        //display น้ำหนัก
weight = double.Parse(Console.ReadLine());                //input keyboard and convert

BMI = height/weight;                                      //หาร
BMI = Math.Pow(BMI,2);                                    //การทำเลข ยกกำลัง


Console.WriteLine ("***************************************************************");
Console.WriteLine ("Student ID : " + ID );
Console.WriteLine ("Full name : " + prefix +" "+fname+"  "+lname );
Console.WriteLine ("height : " + height );
Console.WriteLine ("weight : " + weight );
Console.WriteLine ("BMI is : " + BMI);                    //ค่าดัชนีมวลกาย
Console.WriteLine ("***************************************************************");

