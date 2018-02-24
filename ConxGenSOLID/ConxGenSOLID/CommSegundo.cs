using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace ConxGenSOLID
{
    class CommSegundo : InitConexion
    {

        public string secCommTxt { get; set; }
        public static DbDataReader secrd;
        public static DbCommand secCommand;
        public static object[] extract;
        public void secreader(string othercomm)
        {
            secCommTxt = othercomm;

            secCommand = conex.CreateCommand();
            secCommand.CommandText = othercomm;
            secCommand.CommandType = CommandType.Text;
            secrd = null;

            secrd = secCommand.ExecuteReader();
            extract = new object[secrd.FieldCount];
            while (secrd.Read())
            {

                for (int i = 0; i < secrd.FieldCount; i++)
                {
                    Console.WriteLine(extract[i] = secrd.GetValue(i).ToString());
                }

            }


        }

    }

}
/*TRABAJO ELABORADO POR ELNNON CARACAS - CLASE DE PROGRAMACION AVANZADA - FECHA ENTREGA 25 DE FEBRERO DE 2018*/
