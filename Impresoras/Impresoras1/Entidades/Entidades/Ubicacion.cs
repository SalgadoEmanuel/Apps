using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public class Ubicacion : EntidadBase
    {
        public string Descripcion { get; set; }

        public IEnumerable<InventarioTonners> InventarioTonneersList { get; set; }

    }
}
