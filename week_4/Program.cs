
//operators +   บวก************************************************************************************
/*
int plus1 = 2 ;
int plus2 = 3 ;
int total;

total = plus1 + plus2;

Console.Write(" = " + total);
*/

//operators -   ลบ************************************************************************************
/*
int minus1 = 2 ;
int minus2 = 3 ;
int total;

total = minus1 - minus2;

Console.Write(" = " + total);
*/

//operators /  หาร************************************************************************************
/*
double plus1 = 2 ;
double plus2 = 3 ;
double total;

total = plus1 / plus2;

Console.Write(" = " + total);
*/

//operators %  เปอร์เซน************************************************************************************
/*
int modul1 = 5 ;
int modul2 = 3 ;
int total;

total = modul1 % modul2;

Console.Write(" = " + total);
*/

/////operators ++++ บวก ที่ละ 1************************************************************************************
/*
int plus = 0 ;
int total = 0 ;

plus++;

total = plus++;

Console.Write(" = " + total);
*/

/////operators - - - ลบ ที่ละ 1************************************************************************************
/*
int minus = 10 ;
int total = 0 ;

minus--;

total = minus--;

Console.Write(" = " + total);
*/



//Math ฟังชั่นคณิต************************************************************************************
/*
int min = Math.Min ( 5 , 1 );
Console.WriteLine(" = " + min);

int max = Math.Max ( 5 , 1 );
Console.Write(" = " + max);
*/


///string  ข้อความ************************************************************************************
/*
string greeting = "Hello";
string word = "word";
Console.Write(" = " + greeting +" "+ word);
*/

/// Booleans ถูก ผิด เปรียบเทียบบบ
/*
bool val = false;
bool check = false;

Console.Write(val == check);
*/

//If ... Else************************************************************************************
/*
int input;
Console.Write("input value : ");
input = Int32.Parse(Console.ReadLine());

if(input == 2){
Console.Write("True");
}

else if(input == 3){
    Console.Write("Yes this is = 3");
}

else if(input == 4){
    Console.Write("Yes this is = 4");
}

else if(input == 5){
    Console.Write("Yes this is = 5");
}

else if(input == 6||input == 12 ){
    Console.Write("Yes this is = 6 or 12");
}

else{
    Console.Write("false");
}
*/

//Switch เปิด ปิด************************************************************************************
/*
int day;
Console.Write("input value : ");
day = Int32.Parse(Console.ReadLine());
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
    Console.WriteLine("หาไม่เจอโว๊ยยยยยย");
    break;
}
*/

///While Loop**********************************************************************************************
/*
string[] cars = {
    "Volvo", "BMW", "Ford", "Mazda" , "Honda" ,
     "Toyota" , "Misubishi" , "nissan"
    };

string[] color = {
    "Red", "Green", "Blue", "Black" , "White" ,
     "Cyan" , "Yellow" , "Dark"
};
int i = 0;
int seq = 1;
while ( i < 8 )
{
   //i++;
  Console.WriteLine(( i + seq  ) + ". ยี่ห้อ " +  " " + cars[i] +  " " + " สี " + color[i] );
    i++;
}
*/


// *********************การรรรร   บ้านนนนนน ***************************************************
string[] id = {
    "663245001", "663245002", "663245003", "663245004" , "663245005" ,
     "663245006" , "663245007" , "663245009"
    };


string[] refix = {
    "Mr.", "Mr.", "Mr.", "Mr." , "Mr." ,
     "Miss" , "Miss" , "Mr."
};


string[] fname = {
    "Kittiphong", "Tanakorn", "Pongsakon", "Watcharapong" , "Intat" ,
     "Kannikar" , "Thanaporn" , "Kittisak"
};

string[] lname = {
    "Chaimon", "Suphaphut", "Kongnoi", "Maneengam" , "Kanalaksombat" ,
     "Patposri" , "Hongngam" , "Srisuk"
};

int i = 0;
int seq = 1;
while ( i < 8 )
{
  Console.WriteLine((seq++) + ".  "+ refix[i]+ " "+ fname[i] + " "+ lname[i] +" " + " Id" + ". "  + id[i] );
    i++;
}

//********************************************************************************************************
