using System;
namespace Program
{
    class CoffeeLuxer { }

    class CoffeePremuim
    {
        public static void Main(string[] args) //จุดเริ่มต้นของการเริ่ม ( เหมือนประตูทางเข้า )
        {
            int val;

            CoffeePremuim CP = new CoffeePremuim();//เปลี่ยนตัวแปลเป็นตัวย่อ
            CP.selected_band(); //Display Band
            val = Int32.Parse(Console.ReadLine());
            CP.Line();
            CP.Routes(val);
            CP.Line();
        }

        public void selected_band()
        {
            Console.WriteLine("Please selected Band Coffee ");
            Console.WriteLine("1 : Amezon ");
            Console.WriteLine("2 : Inthanin");
            Console.WriteLine("3 : Punthai");
            Console.WriteLine("4 : D-Oro");
            Console.Write("Selected : ");
        }
        public void Routes(int val)
        {
            CoffeePremuim CP = new CoffeePremuim();

            switch (val)
            {
                case 1:
                    {
                        CP.amezon();
                        break;
                    }
                case 2:
                    {
                        CP.inthanin();
                        break;
                    }
                case 3:
                    {
                        CP.punthai();
                        break;
                    }
                case 4:
                    {
                        CP.doro();
                        break;
                    }
            }

        }

        public void Line()
        {
            Console.WriteLine("-----------------------");
        }

        public void amezon()
        {
            Console.WriteLine("******Amezon cafe******");
            Console.WriteLine(" --What do you want-- ?");
            Console.WriteLine(" 1. Black Coffee");
            Console.WriteLine(" 2. Capu Chino");
            Console.WriteLine(" 3. Late");
        }

        public void inthanin()
        {
            Console.WriteLine("*****Inthanin cafe*****");
            Console.WriteLine(" --What do you want-- ?");
            Console.WriteLine(" 1. Black Mix Orange");
            Console.WriteLine(" 2. Capu Chino");
            Console.WriteLine(" 3. Late");
        }

        public void punthai()
        {
            Console.WriteLine("******Punthai cafe*****");
            Console.WriteLine(" --What do you want-- ?");
            Console.WriteLine(" 1. Chocolate");
            Console.WriteLine(" 2. Americano");
        }

        public void doro()
        {
            Console.WriteLine("******D - Oro cafe*****");
            Console.WriteLine(" --What do you want-- ?");
            Console.WriteLine(" 1. Milk Chocolate");
            Console.WriteLine(" 2. Capu Chino");
        }
    }
}

