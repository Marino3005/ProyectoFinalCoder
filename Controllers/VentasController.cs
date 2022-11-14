using EntregaCoder.Models;
using EntregaCoder.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntregaCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        [HttpGet("GetVentasPorUsuario")]
        public List<Venta> GetVentas(int IdUsuario)
        {
            return ADO_Ventas.Traer_Ventas(IdUsuario);
        }

        [HttpPost("CargarVenta")]
        public void CargarVenta( int idUsuario, string comentario, List<ProductoVendido> listaProductos)
        {
            ADO_Ventas.Cargar_Venta(idUsuario, comentario, listaProductos);
        }

        [HttpGet("GetTodasVentas")]
        public List<Venta> GetTodasVentas()
        {
            return ADO_Ventas.Traer_Todas_Ventas();
        }

        [HttpGet("GetVentasYProductos")]
        public List<VentaCompleta> GetVentasCompletas()
        {
            return ADO_Ventas.Traer_VentasyProductos();
        }

        [HttpDelete("EliminarVenta")]
        public void EliminarVenta(int idVenta)
        {
            ADO_Ventas.Eliminar_Venta(idVenta);
        }
    }
}
