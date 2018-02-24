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
            /*INICIANDO LA CONEXION A LA BD*/
            /*MI CODIGO -- INICIO*/
            InitConexion Conectar = new InitConexion();
            ConCloser Desconectar = new ConCloser();
            ConCommander Comandeishon = new ConCommander();
            CommSegundo segcomando = new CommSegundo();
            ImprimirDread imp = new ImprimirDread();
            Conectar.ConectarDB(@"Data Source=DESKTOP-8MI8C4P;Initial Catalog=DBCONFIG_E;Integrated Security=True", "System.Data.SqlClient");/*MS-SQL SERVER*/
            Comandeishon.consultaR(@"SELECT NOMBREPROV,CADENA,NCONSULTA FROM ((PROVEEDORES INNER JOIN CADENACONECT ON PROVEEDORES.ID = CADENACONECT.CID) INNER JOIN SQUERIES ON SQUERIES.ID = CADENACONECT.CID) WHERE CID = 1");
            Desconectar.conxcloser();
            /*OBTENIENDO SQL QUERY PARA CONSULTAR LA SEGUNDA DB*/
            Conectar.ConectarDB(ConCommander.miarray[1].ToString(), ConCommander.miarray[0].ToString());/*POSTGRESQL*/
            segcomando.secreader(ConCommander.miarray[2].ToString());
            Desconectar.conxcloser();
            imp.imprime();
            /*MI CODIGO -- FIN*/
            //Comandeishon.consultaR(@"SELECT NOMBRE,APELLIDO,NPUESTO,SALARIO FROM EMPLEADO INNER JOIN SUELDOS ON EMPLEADO.FKPTRAB = SUELDOS.SPID WHERE NPUESTO = 'VENDEDOR'");
            Console.Read();
            /*CONSULTANDO LA SEGUNDA BD*/











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
