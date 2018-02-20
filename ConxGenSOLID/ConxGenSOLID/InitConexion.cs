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
    class InitConexion
    {
       public static DbConnection conex;
        public static string conxtring { get; set; }
        public static string provDB { get; set; }

        /*Constructor SIN PARAMETROS*/        
        /*public void ConectarDB() {

            conxtring = @"Data Source = DESKTOP - 8MI8C4P; Initial Catalog = DBCONFIG_E; Integrated Security = True";
            provDB = "System.Data.SqlClient";

            DbProviderFactory FactDB = DbProviderFactories.GetFactory(provDB);
            conex = FactDB.CreateConnection();
            conex.ConnectionString = conxtring;
            try
            {
                conex.Open();
                Console.WriteLine(conex.State);


            }
            catch (Exception exec)
            {
                Console.WriteLine("Error: " + "\t" + exec);

            }

            conex.Close();
            Console.WriteLine(conex.State);

        }*/
        /*FIN CONSTRUCTOR SIN PARAMETROS*/
        public void ConectarDB(string conxstring, string dbprovi) {

            conxtring = conxstring;
            provDB = dbprovi;

            DbProviderFactory FactDB = DbProviderFactories.GetFactory(dbprovi);
            conex = FactDB.CreateConnection();
            conex.ConnectionString = conxstring;
            
            try
            {
                conex.Open();
                Console.WriteLine("Estado de la Conexion: "+conex.State);


            }
            catch (Exception exec)
            {
                Console.WriteLine("Error: "+"\t"+exec);
                
            }
        }


    }
}
