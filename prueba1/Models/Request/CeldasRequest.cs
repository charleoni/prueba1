using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba1.Models.Request
{
    public class CeldasRequest
    {
        public int dias { get; set; }
        public int celda1 { get; set; }
        public int celda2 { get; set; }
        public int celda3 { get; set; }
        public int celda4 { get; set; }
        public int celda5 { get; set; }
        public int celda6 { get; set; }
        public int celda7 { get; set; }
        public int celda8 { get; set; }
    }


    public class Rootobject
    {
        public int Días { get; set; }
        public string Entrada { get; set; }
        public string Salida { get; set; }
    }

}