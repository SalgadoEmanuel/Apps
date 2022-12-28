using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ViewModels
{
    public class InventarioViewModel
    {
        public InventarioTonners Inventario { get; set; }
        public IEnumerable<Tonner> Tonner { get; set; }
        public IEnumerable<Ubicacion> Ubicacion { get; set; }
    }
}

