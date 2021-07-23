using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project1
{
    class Class1
    {
        MySqlConnection con;
        MySqlCommand cmd;

        public Class1()
        {
            string connectionstring = "server=localhost;user =root; password=root; database=nbs";
            con = new MySqlConnection(connectionstring);
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }

        public void createRecord(string ProductName, int Quantity, float Price)

        {
            //MySqlDataReader data = cmd.ExecuteReader();
            cmd.CommandText = $"insert into Sales(productname,quantity,price,salesdate) values ('{ProductName}', {Quantity}, {Price},now())";
            cmd.ExecuteNonQuery();

                        //cmd.close();
        }

        public void ProdYr(int Year)
        {
            string sqlSelect = $"select * from sales where concat(Year(SalesDate)) = {Year};";
            showRecords(sqlSelect);
        }

        public void ProdMY(int PM, int PY)
        {
            string sqlSelect = $"select * from sales where concat(Year(SalesDate)) = {PY} and(month(SalesDate)) = {PM}";
            showRecords(sqlSelect);
        }


        public void SalesYr(int SaleYr)
        {
            string sqlSelect = $"select count(*) from Sales where concat(Year(SalesDate)) = {SaleYr}";
            
           
            cmd.CommandText = sqlSelect;
            cmd.ExecuteNonQuery();
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Console.WriteLine("total sales : " + data.GetString(0));
            }
            Console.Read();
            data.Close();
            
        }

        public void SalesMY(int SlMo, int SlYr)
        {          
            string sqlSelect = $"select count(*) from Sales where concat(Year(SalesDate)) = {SlYr} and (month(SalesDate)) = {SlMo}";

            cmd.CommandText = sqlSelect;
            cmd.ExecuteNonQuery();
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Console.WriteLine("total sales : " + data.GetString(0));
            }
            Console.Read();
            data.Close();
        }
       

        public void showRecords(string sqlSelect)
        {
            cmd.CommandText = sqlSelect;
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Console.WriteLine(data[0] + ".........." + data[1] + "............" + data[2] + "..........." + data[3] + "..........." + data[4]);
            }
            Console.Read();
            data.Close();

        }

        
       
    }

    class SelectedChoice {

        MySqlConnection con;
        MySqlCommand cmd;

        public SelectedChoice() { 

            string connectionstring = "server=localhost;user =root; password=root; database=nbs";
            con = new MySqlConnection(connectionstring);
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
        }

        






        
    }






    







}   
