using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1
{
    class SalesInformationSystems
    {
        Class1 dbf;
        public void MainMenu()
        {
            dbf = new Class1();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Data Entry");
            Console.WriteLine("2. Reports");
            Console.WriteLine("3. Exit");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1)
            {
                DataEntry();

            }

            if (choice == 2)
            {
                Reports();
            }

            if (choice == 3)
            {
                Environment.Exit(0);
            }

        }
        private void DataEntry (){
                Console.WriteLine("D a t a   E n tr y   S c r e e n ");
                string choice = "Y";
                while (choice == "Y" || choice == "y")
                {
                    Console.Write("Enter Product Name: ");
                    string ProductName = Console.ReadLine();

                    Console.Write("Enter Quantity: ");
                    int Quantity = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Price: ");
                    float Price = float.Parse(Console.ReadLine());

                    dbf.createRecord(ProductName, Quantity, Price);

                    Console.WriteLine("Do you want to add another sales record");
                    choice = Console.ReadLine();
                    if (choice != "Y" || choice != "Y")
                    {
                    MainMenu();
                    } 
                }
        }

        private void Reports (){
            Console.WriteLine("R E P O R T S  S C R E E N");


           // string choice = "Y";
           // while (choice == "Y" || choice == "y")
           // {
                Console.WriteLine("1. Report of the list of products sold in a specific year");
                Console.WriteLine("2. Report of the list of products sold in a specific month of a year");
                Console.WriteLine("3. Report of the total sales in a specific year");
                Console.WriteLine("4. Report of the total sales in a specific month of a specific year");
                Console.WriteLine("5. Return to main menu");
                Console.WriteLine("6. Exit");

                int selection = Int32.Parse(Console.ReadLine());


                if (selection == 1)
                {

                    Console.WriteLine("Enter Sales Year");
                    int Year = Int32.Parse(Console.ReadLine());
                    dbf.ProdYr(Year);

                    Console.WriteLine("Press 1 to return to main menu");
                    Console.WriteLine("Press 2 to Exit");
                    Console.ReadLine();
                    int ch = Int32.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        MainMenu();
                    }
                    if (ch == 2)
                    {
                        Environment.Exit(0);
                    }


                }
                if (selection == 2)
                {
                    Console.WriteLine("Enter Sales month");
                    int PM = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Sales year");
                    int PY = Int32.Parse(Console.ReadLine());

                    dbf.ProdMY(PM, PY);

                    Console.WriteLine("Press 1 to return to main menu");
                    Console.WriteLine("Press 2 to Exit");
                    Console.ReadLine();
                    int ch = Int32.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        MainMenu();
                    }
                    if (ch == 2)
                    {
                        Environment.Exit(0);
                    }




                }
                if (selection == 3)
                {
                                                
                Console.WriteLine("Enter Sales Year");                
                int SlYear = Int32.Parse(Console.ReadLine());
                dbf.SalesYr(SlYear);

                Console.WriteLine("Press 1 to return to main menu");
                Console.WriteLine("Press 2 to Exit");
                Console.ReadLine();
                int ch = Int32.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    MainMenu();
                }
                if (ch == 2)
                {
                    Environment.Exit(0);
                }

                }

                if (selection == 4)
                {
                    Console.WriteLine("Enter Sales month");
                    int SlMo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Sales year");
                    int SlYr = Int32.Parse(Console.ReadLine());

                    dbf.SalesMY(SlMo, SlYr);

                    Console.WriteLine("Press 1 to return to main menu");
                    Console.WriteLine("Press 2 to Exit");
                    Console.ReadLine();
                    int ch = Int32.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        MainMenu();
                    }
                    if (ch == 2)
                    {
                        Environment.Exit(0);
                    }

                }
                if (selection == 5)
                {
                MainMenu();
                }


                if (selection == 6)
                {
                Environment.Exit(0);
                }

                


           // } 

        }
    }
}
