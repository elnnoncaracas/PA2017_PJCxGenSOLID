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
    class ConCloser : InitConexion
    {
        
        public void conxcloser() {
            
            DbProviderFactory FactDB = DbProviderFactories.GetFactory(provDB);
            conex = FactDB.CreateConnection();
            conex.ConnectionString = conxtring;
            try
            {
                conex.Close();
                Console.WriteLine("Estado de la Conexion: " + conex.State);
                Console.Read();


            }
            catch (Exception exec)
            {
                Console.WriteLine("Error: " + "\t" + exec);

            }


        }
    }
}
