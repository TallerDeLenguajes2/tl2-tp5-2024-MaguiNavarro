//dejar las variables solo con set, para que no lo puedan modificar

using System;
using System.Collections.Generic;



public  class PresupuestosDetalle
{
    private Producto prod;
    private int cantidad;
    
     public PresupuestosDetalle()
    {
    }
    public PresupuestosDetalle(int cantidad,Producto producto){
        Cantidad= cantidad;
        prod= producto;
    }

    public Producto Prod { get => prod; set => prod = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }


}