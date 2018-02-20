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
    class ConCommander:InitConexion
    {
        public static DbCommand mycommand;
        public string CommTxt { get; set; }
        public static DbDataReader dbdr;

        public void consultaR(string comtext) {

            CommTxt = comtext;

            mycommand = conex.CreateCommand();
            mycommand.CommandText = comtext;
            mycommand.CommandType = CommandType.Text;
            dbdr = null;
            dbdr = mycommand.ExecuteReader();

            while (dbdr.Read())
            {

                for (int i = 0; i < dbdr.FieldCount; i++)
                {

                    Console.WriteLine(dbdr.GetName(i) + ": " + dbdr.GetValue(i) + "\n");
                }

            }
        }

    }
}
