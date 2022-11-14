namespace EntregaCoder.Models
{
    public class Venta
    {
        public int id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }
    }

    public class VentaCompleta
    {
        public int IdVenta { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
    }
}
