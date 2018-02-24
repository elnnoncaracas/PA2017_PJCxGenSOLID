using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace ConxGenSOLID
{

    class CommSegundo : ConCommander
    {
        public static DbDataReader secdr { get; set; }

        public void secreader(string othercomm)
        {
            CommTxt = othercomm;

            mycommand = conex.CreateCommand();
            mycommand.CommandText = othercomm;
            mycommand.CommandType = CommandType.Text;
            secdr = null;

            secdr = mycommand.ExecuteReader();


            object[] Oarray = new object[secdr.FieldCount];
            while (secdr.Read())
            {

                for (int i = 0; i < dbdr.FieldCount; i++)
                {

                    Oarray[i] = dbdr.GetValue(i);
                    Console.WriteLine(Oarray[i]);   

                }

            }
        }
    }
}