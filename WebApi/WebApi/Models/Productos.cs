using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Productos
    {
        [Key]
        public int idProducto { get; set; }
        public string Producto { get; set; }
    }
}
