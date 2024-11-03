using Microsoft.AspNetCore.Mvc;

namespace APITP5.Controllers;

[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private PresupuestoRepository presRep;

    public PresupuestosController()
    {
        presRep = new PresupuestoRepository();
    } 

    [HttpPost("crearPresupuesto")]
    public ActionResult crearPresupuesto([FromBody] Presupuesto presupuesto)
    {
        presRep.create(presupuesto);
        return Ok();
    }

    [HttpPost("AgregarDetalle")]
    public ActionResult agregarDetalle([FromBody]Producto producto, int cantidad, int idPresupuesto)
    {
        var detalle = new PresupuestosDetalle();
        detalle.asignarProd(producto);
        detalle.Cantidad = cantidad;

        presRep.agregarDetalle(detalle, idPresupuesto);
        return Ok();
    }

    [HttpPost("AgregarDetalle2")]
    public ActionResult agregarDetalle(PresupuestosDetalle detalle, int idPresupuesto)
    {
        presRep.agregarDetalle(detalle, idPresupuesto);
        return Ok();
    }

    [HttpGet("listarPresupuesto")]
    public ActionResult<List<Presupuesto>> ListarPresupuestos()
    {
        var listaPres = presRep.listarPresupuestos();
        return Ok(listaPres);
    }

    [HttpGet("{id}")]
        public IActionResult ObtenerPresupuesto(int id)
        {
            var presupuesto = presRep.GetPresupuesto(id);
            if (presupuesto == null)
            {
                return NotFound($"No se encontró el presupuesto con ID = {id}");
            }
            
            return Ok(presupuesto);
        }

}