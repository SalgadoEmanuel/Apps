using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Impresora : EntidadBase
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SN { get; set; }
        public string IP { get; set; }
        public int TonnerId { get; set; }
        public bool Estado { get; set; }


        public Tonner Tonner { get; set; }

    }
}