using System;
using System.Collections.Generic;


public class Presupuesto
{
    private int idPresupuesto;
    private string nombreDestinario;
    private List <PresupuestosDetalle> detalle;


   public Presupuesto(){ }
   public Presupuesto(int id, string nombre){
       
       idPresupuesto= id;
       nombreDestinario= nombre;
       detalle= new List<PresupuestosDetalle>();

   }
    public List<PresupuestosDetalle> Detalle { get => detalle; }
    public string NombreDestinario { get => nombreDestinario;}
    public int IdPresupuesto { get => idPresupuesto;  }


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