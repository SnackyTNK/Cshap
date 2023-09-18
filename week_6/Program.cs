int loop = 0 ; // วนรับข้อมูล 3 รอบ


Console.Write("How many record input :");     // Display
loop = Int32.Parse(Console.ReadLine());       // int put int loop



string student_ID , prefix , Fname , Lname , score;

string[][] data = new string[loop][];


string grade;
int point;


//วน loop เพื่อเก็บข้อมูล
for(int i = 0 ; i < loop; i++ ){
Console.Write("input student ID :");
student_ID = Console.ReadLine();

Console.Write("input prefix :");
prefix = Console.ReadLine();

Console.Write("input first name :");
Fname = Console.ReadLine();

Console.Write("input last name :");
Lname = Console.ReadLine();

Console.Write("input score :");
score = Console.ReadLine();

Console.WriteLine("-----------------------------------------------------------------------------");

//Save to data
data [i] = new string[] { student_ID , prefix , Fname , Lname , score };

};

      //วนเพื่อแสดงข้อมูล
for(int i = 0 ; i < loop ; i++ )
{
     //เช็คเกรด
point = Int32.Parse(data[i][4]);
     //ตัดเกรด
if(point >= 80 ){
    grade = "A = เก่งมากเทพพระบุตรส่งมาเกิด" ;
    }else if (point >= 75 ){
    grade = "B+ = ดีมาก"; 
     }else if (point >= 70 ){
    grade = "B = ถือว่าดี";   
     }else if (point >= 65 ){
    grade = "C+ = พอใช้นะ";
     }else if (point >= 60 ){
    grade = "C = เกือบจะดีละ";
     }else if (point >= 55 ){
    grade = "D+ = พยายามให้มากๆหน่อย";
     }else if (point >= 50 ){
    grade = "D = รอเรียนใหม่ได้เลย";
    }else if (point == 0 ){
    grade = "i = มึงเลิกเรียนไปเหอะ";
     }else{
     grade ="E โง่จริงๆ";   
     }

Console.WriteLine("ID : " + data[i][0]);
Console.WriteLine("Full Name : " + data[i][1] + data[i][2] +"  "+ data[i][3] );
Console.WriteLine("Your grade : " + grade );

}
























