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
            int menu;

            switch (val)
            {
                case 1:
                    {
                        CP.amezon();
                        Console.Write(" Pls selected : ");
                        menu = Int32.Parse(Console.ReadLine());
                        CP.Line();
                        CP.amezon_menu(menu);
                        break;
                    }
                case 2:
                    {
                        CP.inthanin();
                        Console.Write(" Pls selected : ");
                        menu = Int32.Parse(Console.ReadLine());
                        CP.Line();
                        CP.inthanin_menu(menu);
                        break;
                    }
                case 3:
                    {
                        CP.punthai();
                        Console.Write(" Pls selected : ");
                        menu = Int32.Parse(Console.ReadLine());
                        CP.Line();
                        CP.punthai_menu(menu);
                        break;
                    }
                case 4:
                    {
                        CP.doro();
                        Console.Write(" Pls selected : ");
                        menu = Int32.Parse(Console.ReadLine());
                        CP.Line();
                        CP.doro_menu(menu);
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
            Console.WriteLine("    What do you want  ?");
            Console.WriteLine(" 1. Black Coffee");
            Console.WriteLine(" 2. Capu Chino");
            Console.WriteLine(" 3. Late");

        }
        public void amezon_menu(int menu)
        {
            switch (menu)
            {
                case 1:
                    {
                        Console.WriteLine(" Your Drink - Black coffee 50  bath ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Your Drink - Capu Chino   60  bath ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" Your Drink - Late   65  bath ");
                        break;
                    }
            }
        }
        public void inthanin_menu(int menu)
        {
            switch (menu)
            {
                case 1:
                    {
                        Console.WriteLine(" Your Drink - Black coffee Orange  80  bath ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Your Drink - Capu Chino   60  bath ");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" Your Drink - Late   65  bath ");
                        break;
                    }
            }
        }
        public void punthai_menu(int menu)
        {
            switch (menu)
            {
                case 1:
                    {
                        Console.WriteLine(" Your Drink - Chocolate 55  bath ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Your Drink - Americanno 40  bath ");
                        break;
                    }
            }
        }
        public void doro_menu(int menu)
        {
            switch (menu)
            {
                case 1:
                    {
                        Console.WriteLine(" Your Drink - Milk Chocolate  100  bath ");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(" Your Drink - Capu Chino   60  bath ");
                        break;
                    }
            }
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

