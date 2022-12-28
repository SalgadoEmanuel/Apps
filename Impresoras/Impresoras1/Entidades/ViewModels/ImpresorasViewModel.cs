using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ViewModels
{
    public class ImpresorasViewModel
    {
        public Impresora Impresora { get; set; }

        public IEnumerable<Tonner> Tonner { get; set; }

    }
}
