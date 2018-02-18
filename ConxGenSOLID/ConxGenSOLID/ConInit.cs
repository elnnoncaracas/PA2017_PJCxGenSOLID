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
        static DbConnection conx;
        static DbCommand cmd;
        static string proveedordb = "System.Data.SqlClient";
        static string connString = @"Data Source=DESKTOP-8MI8C4P;Initial Catalog=DBCONFIG_E;Integrated Security=True";
        public string cmdTxt;

        public static void Despelote() {
            DbProviderFactory ConFab = DbProviderFactories.GetFactory(proveedordb);
            conx = ConFab.CreateConnection();
            conx.ConnectionString = connString;
            try {

                conx.Open();
                Console.WriteLine("Estado de la Conexion: "+conx.State);

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
