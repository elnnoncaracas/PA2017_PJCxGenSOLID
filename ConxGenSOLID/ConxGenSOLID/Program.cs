﻿using System;
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

            MenuOpciones men = new MenuOpciones();
            men.mostrar();
            Console.Read();
            ConInit.Despelote();

        }
    }
}
