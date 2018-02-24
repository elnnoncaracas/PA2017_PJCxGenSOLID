using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConxGenSOLID
{
    class ImprimirDread : CommSegundo
    {
        public void imprime(){
            while (secdr.Read()){
                for (int i = 0; i < secdr.FieldCount; i++)
                {

                    Console.WriteLine(secdr.GetValue(i));

                }
            }
            }
    }
}
