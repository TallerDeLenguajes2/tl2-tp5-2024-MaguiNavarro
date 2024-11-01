using System;
using System.Collections.Generic;


public class Presupuesto
{
    private int idPresupuesto;
    private string nombreDestinario;
    private List <PresupuestosDetalle> detalle;
       DateTime fechaCreacion;
 
   public Presupuesto(){
       
       fechaCreacion = DateTime.Now;
       detalle= new List<PresupuestosDetalle>();

   }
    public List<PresupuestosDetalle> Detalle { get => detalle;   }
    public string NombreDestinario { get => nombreDestinario; set=>nombreDestinario=value ; }
    public int IdPresupuesto { get => idPresupuesto; set=>idPresupuesto =value;   }
     public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }


    public int MontoPresupuesto( ){
       int total= 0;
       foreach (PresupuestosDetalle pd in detalle)
       {
          total +=  pd.Prod.Precio * pd.Cantidad ;
       }

       return total;

    }
    public double MontoPresupuestoConIva(){
         int cantSinIva = MontoPresupuesto();
        return cantSinIva * 1.21;
    }
      public int CantidadProductos()
    {
        return Detalle.Sum(d => d.Cantidad);
    }
   
}