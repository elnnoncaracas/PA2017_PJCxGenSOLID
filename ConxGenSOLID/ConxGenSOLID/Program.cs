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


            InitConexion Conectar = new InitConexion();
            ConCloser Desconectar = new ConCloser();
            ConCommander Comandeishon = new ConCommander();
            Conectar.ConectarDB(@"Data Source=DESKTOP-8MI8C4P;Initial Catalog=DBCONFIG_E;Integrated Security=True", "System.Data.SqlClient");/*MS-SQL SERVER*/
            Console.Read();
            Comandeishon.consultaR(@"SELECT NOMBREPROV, CADENA FROM PROVEEDORES INNER JOIN CADENACONECT ON PROVEEDORES.ID = CADENACONECT.CID WHERE CID = 1");
            Desconectar.conxcloser();
            Conectar.ConectarDB(@"Server =baasu.db.elephantsql.com; Port = 5432; Database = oxlrtoxo; User Id = oxlrtoxo; Password =   MJMV0caqyufWcjuMNSqda_dIw-wMgHrO", "Npgsql");/*POSTGRE_SQL*/
            Comandeishon.consultaR(@"SELECT NOMBREPROV, CADENA FROM PROVEEDORES INNER JOIN CADENACONECT ON PROVEEDORES.ID = CADENACONECT.CID");
            Console.Read();
            Desconectar.conxcloser();
            Console.Read();











            /*
            // MenuOpciones men = new MenuOpciones();
            //men.mostrar();
            //ConInit.Despelote();
            //InitConexion Conextad = new InitConexion();
            //ConCloser Cierra = new ConCloser();
            //Conextad.ConectarDB(@"Data Source=DESKTOP-8MI8C4P;Initial Catalog=EMPRESA;Integrated Security=True", "System.Data.SqlClient");/*MS-SQL SERVER*/
            //Conextad.ConectarDB(@"Server =babar.elephantsql.com; Port = 5432; Database = bmfkgevd; User Id = bmfkgevd; Password =  1erS7WgQ83Ql3i9DRjJk5mT_CV64jTwX", "Npgsql");/*POSTGRES SQL*/
            //Console.Read();
            //ConCommander mande = new ConCommander();
            //mande.consultaR(@"SELECT NOMBRE,APELLIDO,NPUESTO,SALARIO FROM EMPLEADO INNER JOIN SUELDOS ON EMPLEADO.FKPTRAB = SUELDOS.SPID WHERE NPUESTO = 'VENDEDOR'");
            //Cierra.conxcloser();
            //Console.Read();
            //ConxMgr dup = new ConxMgr();*/

        }
    }
}
