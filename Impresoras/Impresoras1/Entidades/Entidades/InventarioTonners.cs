using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class InventarioTonners : EntidadBase
    {
        public int TonnerId { get; set; }
        public int UbicacionId { get; set; }
        public int Cantidad { get; set; }
        public bool Estado { get; set; }
      

        public Tonner Tonner { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
