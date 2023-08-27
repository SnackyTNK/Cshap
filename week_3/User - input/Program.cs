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

Console.WriteLine ("BMI is : " + BMI);    //ค่าดัชนีมวลกาย