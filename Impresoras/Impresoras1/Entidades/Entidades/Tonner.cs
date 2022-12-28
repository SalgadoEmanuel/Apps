using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Tonner : EntidadBase
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Estado { get; set; }

        public IEnumerable<Impresora> ImpresorasList { get; set; }
        public IEnumerable<InventarioTonners> InventarioTonneersList { get; set; }

    }
}