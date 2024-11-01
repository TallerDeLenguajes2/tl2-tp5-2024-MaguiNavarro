// using Microsoft.Data.Sqlite;

// public class PresupuestoRepository
// {
//     private const string cadenaConexion = "Data source=db/Tienda.db;Cache=Shared";

//     public void create(Presupuesto presupuesto)
//     {
//         var querystring = "INSERT INTO Presupuestos (NombreDestinatario, FechaCreacion) VALUES (@NombreDestinatario, @FechaCreacion)";

//         using(SqliteConnection connection = new SqliteConnection(cadenaConexion))
//         {
//             connection.Open();
//             SqliteCommand command = new SqliteCommand(querystring, connection);

//             command.Parameters.Add(new SqliteParameter("@NombreDestinatario", presupuesto.NombreDestinario));
//              command.Parameters.Add(new SqliteParameter("@FechaCreacion", DateTime.Now)); // Ajusta la fecha como corresponda

//             command.ExecuteNonQuery();

//             connection.Close();
//         }

//     }
//      public List<Presupuesto> listarPresupuestos()
//     {
//         var querystring = "SELECT * FROM Presupuestos";
//         var listaPresupuestos = new List<Presupuesto>();

//         using(SqliteConnection connection = new SqliteConnection(cadenaConexion))
//         {
//             connection.Open();
//             SqliteCommand command = new SqliteCommand(querystring, connection);

//             using(SqliteDataReader reader = command.ExecuteReader())
//             {
//                 while(reader.Read())
//                 {
//                     var presupuesto = new Presupuesto();
//                     presupuesto.NombreDestinario = reader["NombreDestinatario"].ToString();
//                     presupuesto.IdPresupuesto = Convert.ToInt32(reader["idPresupuesto"]);
//                     presupuesto.FechaCreacion = (DateTime)reader["FechaCreacion"];
//                     listaPresupuestos.Add(presupuesto);
//                 }
//             }
//             connection.Close();
//         }

//         return listaPresupuestos;
//     }
//      // Obtener detalles de un Presupuesto por su ID
//     public Presupuesto GetPresupuesto(int id)
//     {
//         var presupuesto = new Presupuesto();
//         var querystring = "SELECT * FROM Presupuestos WHERE IdPresupuesto = @IdPresupuesto";

//         using (var connection = new SqliteConnection(cadenaConexion))
//         {
//             connection.Open();
//             var command = new SqliteCommand(querystring, connection);
//             command.Parameters.Add(new SqliteParameter("@IdPresupuesto", id));

//             using (var reader = command.ExecuteReader())
//             {
//                 while(reader.Read())
//                 {
//                     var detalle = new PresupuestosDetalle();
//                     detalle.asignarProd(Convert.ToInt32(reader["idProducto"]));
//                     detalle.Cantidad = Convert.ToInt32(reader["Cantidad"]);
//                     presupuesto.añadirDetalles(detalle);
//                 }
//             }
//             connection.Close();
//         }
//         return presupuesto;
//     }
//      // Método auxiliar para obtener los detalles de productos en un presupuesto
//     private List<PresupuestosDetalle> ObtenerDetallesPresupuesto(int idPresupuesto)
//     {
//         var detalles = new List<PresupuestosDetalle>();
//         var querystring = "SELECT * FROM PresupuestosDetalle WHERE IdPresupuesto = @IdPresupuesto";

//         using (var connection = new SqliteConnection(cadenaConexion))
//         {
//             connection.Open();
//             var command = new SqliteCommand(querystring, connection);
//             command.Parameters.Add(new SqliteParameter("@IdPresupuesto", idPresupuesto));

//             using (var reader = command.ExecuteReader())
//             {
//                 while (reader.Read())
//                 {
//                     var detalle = new PresupuestosDetalle
//                     {
//                         Producto = new Producto
//                         {
//                             IdProducto = Convert.ToInt32(reader["IdProducto"]),
//                             Descripcion = reader["Descripcion"].ToString(),
//                             Precio = Convert.ToInt32(reader["Precio"])
//                         },
//                         Cantidad = Convert.ToInt32(reader["Cantidad"])
//                     };
//                     detalles.Add(detalle);
//                 }
//             }
//             connection.Close();
//         }
//         return detalles;
//     }


// }    
