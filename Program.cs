using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project1
{
    class Program
    {
        MySqlConnection con;
        MySqlCommand cmd;


        static void Main(string[] args)
        {

            SalesInformationSystems tesco = new SalesInformationSystems();
            tesco.MainMenu();



        }
    }
}
