using System;
using System.Collections.Generic;


public class Producto
{
    private int idProducto;
    private string descripcion;
    private int precio;

    public Producto(){
        
    }
     public Producto(int id, string descripcion, int monto){
         IdProducto= id;
         Descripcion= descripcion;
         Precio= monto;
     }

    public int IdProducto { get => idProducto; set => idProducto = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Precio { get => precio; set => precio = value; }


}