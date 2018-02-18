using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConxGenSOLID
{
    class MenuOpciones
    {
        static int opcion;

        public int mostrar() {
            int salida;
            Console.WriteLine("Bienvenido, elige una opcion: ");
            Console.WriteLine("Para salir ingresa -1\n\n\t\t\t\t");
            Console.WriteLine("\n1.- Conectarse a BD MS-SQL");
            Console.WriteLine("\n2.- Conectarse a BD en POSTGRES");
            Console.WriteLine("\n3.- No hay mas opciones");

            opcion = int.Parse(Console.ReadLine());
            while (opcion != -1) {
                switch (opcion) {

                    case 1:
                        Console.WriteLine("Conectarse a BD MS-SQL");
                        salida = 1;
                        break;
                    case 2:
                        Console.WriteLine("Conectarse a BD en POSTGRES");
                        salida = 1;
                        break;
                    default:
                        Console.WriteLine("No hay mas opciones");
                        break;

                }
            }


            return salida;
        }
    }
}
