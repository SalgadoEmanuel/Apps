using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidades.Entidades
{
    public class EntidadBase
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}