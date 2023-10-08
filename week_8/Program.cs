using System;
namespace Program
{
    class Finance
    {
        public static void Main(string[] args)
        {
            int number_product = 0;  //จำนวนสินค้า Loop
            string product; //ประกาศตัวแปล ชื่อสินค้า
            string price; //ประกาศตัวแปล ราคา

            //Step 1 จำนวนสินค้า
            Console.Write("How many product? : ");
            number_product = Int32.Parse(Console.ReadLine()); //รับค่าคีบอร์ดเป็น String มาแปลงเป็นอินท์
            string[][] data_product = new string[number_product][]; // aray

            //Step 2 เก็บข้อมูลสินค้า
            for (int i = 0; i < number_product; i++) // i เริ่มที่ 0 ถ้า i น้อยกว่าตัวน้อยรอบ จะทำซ้ำจนกว่าจะไม่ถึงตัวเลขที่กำหนด
            {
                Console.WriteLine();
                Console.Write("input product name : ");     //ใส่ชื่อสินค้า
                product = Console.ReadLine();

                Console.Write("input price: ");            //ใส่ราคา
                price = Console.ReadLine();

                Console.WriteLine("--------------------");


                data_product[i] = new string[] { product, price }; //รับค่าจากข้างบนมาเป็นข้อมูลไว้

            }
            double discount = 0.00;
            double get = 0.00;
            double Vats = 0.00;
            double val = 0.00;

            Console.WriteLine();
            Console.Write("get the money? : ");
            get = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Tax deducted (ex.3-10) ? : ");
            Vats = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.Write("Discount(Bath) : ");
            discount = Int32.Parse(Console.ReadLine());


            val = (100 + Vats);


            //แสดงผลออกมา
            {
                //head
                Console.WriteLine("******************************************");
                Console.WriteLine("                                          ");
                Console.WriteLine("                   Bill                   ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("            Welcome to CarWash24          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("#      Product                       price");
                Console.WriteLine("------------------------------------------");

                //Variable
                double product_price = 0.00;
                double vat = 0.00;
                double Total = 0.00;
                double change = 0.00;


                //Step2
                //Data Product
                for (int i = 0; i < number_product; i++)
                {
                    Console.WriteLine
                    (
                        (i + 1) + "      " +
                        data_product[i][0] + "                          " +
                        data_product[i][1]
                    );
                    //ราคาสินค้าแต่ละรายการ
                    Total += double.Parse(data_product[i][1]);
                }
                vat = Math.Round((Total * Vats) / val, 2);
                Total = (Total - discount);
                product_price = Total - vat;
                change = (get - Total);

                //Step 3
                //footer
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Product price                         " + product_price);
                Console.WriteLine("Tax                                   " + vat);
                Console.WriteLine("Discount                              " + discount);
                Console.WriteLine("Total                                 " + Total);
                Console.WriteLine();

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("get the money                         " + get);
                Console.WriteLine("change                                " + change);
                Console.WriteLine("                                      ");
                Console.WriteLine("     ******Thank You********          ");
                Console.WriteLine("                                      ");
                Console.WriteLine("                                      ");

            }



        }



    }

}