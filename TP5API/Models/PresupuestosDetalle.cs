//dejar las variables solo con set, para que no lo puedan modificar

using System;
using System.Collections.Generic;



public  class PresupuestosDetalle
{
    private Producto prod;
    private int cantidad;

   
    public PresupuestosDetalle(){
       
    }

    public Producto Prod { get => prod;  }
    public int Cantidad { get => cantidad; set => cantidad = value; }


}