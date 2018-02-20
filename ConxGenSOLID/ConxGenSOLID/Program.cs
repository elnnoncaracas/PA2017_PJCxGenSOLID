using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConxGenSOLID
{
    class Program
    {
        static void Main(string[] args)
        {

            // MenuOpciones men = new MenuOpciones();
            //men.mostrar();
            //ConInit.Despelote();
            InitConexion Conextad = new InitConexion();
            ConCloser Cierra = new ConCloser();
            //Conextad.ConectarDB(@"Data Source=DESKTOP-8MI8C4P;Initial Catalog=EMPRESA;Integrated Security=True", "System.Data.SqlClient");/*MS-SQL SERVER*/
            //Conextad.ConectarDB(@"Server =babar.elephantsql.com; Port = 5432; Database = bmfkgevd; User Id = bmfkgevd; Password =  1erS7WgQ83Ql3i9DRjJk5mT_CV64jTwX", "Npgsql");/*POSTGRES SQL*/
            Console.Read();
            ConCommander mande = new ConCommander();
            mande.consultaR(@"Select * from EMPLEADO");
            Cierra.conxcloser();
            Console.Read();
            //ConxMgr dup = new ConxMgr();

     

        }
    }
}
