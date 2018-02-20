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
            Conextad.ConectarDB(@"Data Source=DESKTOP-8MI8C4P;Initial Catalog=DBCONFIG_E;Integrated Security=True", "System.Data.SqlClient");
            Console.Read();
            Cierra.conxcloser();
            Console.Read();
            //ConxMgr dup = new ConxMgr();

     

        }
    }
}
