using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Facturas
    {
        [Key]
        public int idFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string TipodePago { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Subtotal { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal Descuento { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal IVA { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalDescuento { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalImpuesto { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Total { get; set; }
    }
}
