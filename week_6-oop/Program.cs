/*
using System;
namespace Program
{


class Grade{

public string grade_is;

public Grade(int score){
int point ;
point = score;
     //ตัดเกรด
if(point >= 80 ){
    grade_is = "A";
    }else if (point >= 75 ){
    grade_is = "B+"; 
     }else if (point >= 70 ){
    grade_is = "B";   
     }else if (point >= 65 ){
    grade_is = "C+";
     }else if (point >= 60 ){
    grade_is = "C";
     }else if (point >= 55 ){
    grade_is = "D+";
     }else if (point >= 50 ){
    grade_is = "D";
    }else if (point == 0 ){
    grade_is = "i";
     }else{
    grade_is ="E";   
     }

}

//Function หลัก object |  fuction
static void Main(string[]args){
    
    int point;
    Console.Write("Input score :");
    point =  Int32.Parse(Console.ReadLine());


    Grade score = new Grade(point);
    Console.WriteLine(score.grade_is);

}

}

}
*/

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

            int loop = 0; // วนรับข้อมูล 3 รอบ


            Console.Write("How many record input :");     // Display
            loop = Int32.Parse(Console.ReadLine());       // int put int loop



            string student_ID, prefix, Fname, Lname, xscore;

            string[][] data = new string[loop][];


            string grade;
            int point;


            //วน loop เพื่อเก็บข้อมูล
            for (int i = 0; i < loop; i++)
            {
                Console.Write("input student ID :");
                student_ID = Console.ReadLine();

                Console.Write("input prefix :");
                prefix = Console.ReadLine();

                Console.Write("input first name :");
                Fname = Console.ReadLine();

                Console.Write("input last name :");
                Lname = Console.ReadLine();

                Console.Write("input score :");
                xscore = Console.ReadLine();

                Console.WriteLine("-----------------------------------------------------------------------------");

                //Save to data
                data[i] = new string[] { student_ID, prefix, Fname, Lname, xscore };



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




