using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Npgsql;
using Mono.Security;

namespace ConxGenSOLID
{
    class ConCommander : InitConexion
    {
        public static DbCommand mycommand;
        public string CommTxt { get; set; }
        public static DbDataReader dbdr;
        public static object var1, var2;
        public void consultaR(string comtext)
        {
            //string oye;
            CommTxt = comtext;

            mycommand = conex.CreateCommand();
            mycommand.CommandText = comtext;
            mycommand.CommandType = CommandType.Text;
            dbdr = null;
            dbdr = mycommand.ExecuteReader();
          

            while (dbdr.Read())
            {



                var1 = dbdr.GetValue(1);
                var2 = dbdr.GetValue(0);
               

                for (int i = 0; i <dbdr.FieldCount; i++)
                {
                    Console.WriteLine(dbdr.GetValue(i));
                }

            }
        }

    }
}
