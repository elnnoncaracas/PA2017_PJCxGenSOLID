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
    class ConInit
    {
        public static DbConnection conx;
        public static DbCommand cmd;
        static string proveedordb = "System.Data.SqlClient";
        static string connString = @"Data Source=DESKTOP-8MI8C4P;Initial Catalog=DBCONFIG_E;Integrated Security=True";
        static string cmdTxt = "select * from SQUERIES";

        public static void Despelote() {
            
            DbProviderFactory ConFab = DbProviderFactories.GetFactory(proveedordb);
            conx = ConFab.CreateConnection();
            conx.ConnectionString = connString;
            try {

                conx.Open();
                Console.WriteLine("Estado de la Conexion: "+conx.State);
                cmd = conx.CreateCommand();
                cmd.CommandText = cmdTxt;
                cmd.CommandType = CommandType.Text;
                DbDataReader dbdr = null;
                dbdr = cmd.ExecuteReader();
                while (dbdr.Read()) {

                    for (int i = 0; i<dbdr.FieldCount;i++) {

                        Console.WriteLine(dbdr.GetName(i) + ": " + dbdr.GetValue(i)+"\n");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la conexion." + ex);
            }
            conx.Close();
            Console.WriteLine("Connection Status: " + conx.State);
        }
    }
}
