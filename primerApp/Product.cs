using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerApp
{
    public class Usuario
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public string NombreUsuario;
        public string Contraseña;
        public string Mail;
    }

    public class Producto
    {
        public int Id;
        public string Descripcion;
        public double Costo;
        public double PrecioVenta;
        public int Stock;
        public int IdUsuario;
    }

    public class ProductoVendido
    {
        public int Id;
        public int IdProducto;
        public int Stock;
        public int IdVenta;
    }

    public class Venta
    {
        public int Id;
        public string Comentarios;
        public int IdUsuario;
    }
}