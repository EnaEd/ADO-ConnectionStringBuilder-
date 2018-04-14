using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication8
{
    class BdManager
    {
        //Юзаем чере ConnectionStringBuilder
        SqlConnectionStringBuilder connStrBldr = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        public void Open() {
            connStrBldr = new SqlConnectionStringBuilder();
            connStrBldr.DataSource ="PC35-9-p";
            connStrBldr.InitialCatalog ="Shop";
            connStrBldr.IntegratedSecurity =true;
            conn = new SqlConnection();
            conn.ConnectionString = connStrBldr.ConnectionString;
            conn.Open();
        }
        public void Close() {
            conn.Close();
        }
        public void Cmd() {
            using (cmd = new SqlCommand("SELECT* FROM dbo.Items",conn)) {
                rdr = cmd.ExecuteReader();
                do
                {
                    while (rdr.Read()) {
                        for (int i = 0; i < rdr.FieldCount; i++) {
                            Console.Write($"{rdr.GetName(i)} = {rdr.GetValue(i).ToString()}");
                        }
                        Console.WriteLine();
                    }

                } while (rdr.NextResult());
                
            }
        }
        public void Add() {
           
        }
    }
}
