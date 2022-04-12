﻿using System;
using System.Collections.Generic;

namespace WS_Venta.Models
{
    public partial class Ventum
    {
        public Ventum()
        {
            Conceptos = new HashSet<Concepto>();
        }

        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdCliente { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual ICollection<Concepto> Conceptos { get; set; }
    }
}
