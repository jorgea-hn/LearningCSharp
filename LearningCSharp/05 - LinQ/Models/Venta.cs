namespace _05___LinQ.Models;

public class Venta
{
       public Guid Id { get; set; }
       public DateOnly FechaDeVenta { get; set; }
       public float ValorProducto { get; set; }
       public int CantidadDeProductos { get; set; }
       public string Vendedor { get; set; }
       public string Comprador { get; set; }
       public DateOnly TiempoGarantiaFUncionalidades { get; set; }


       public Venta( DateOnly fechaDeVenta, float valorProducto, int cantidadDeProductos, string vendedor,
           string comprador, DateOnly tiempoGarantiaFUncionalidades)
       {
           Id = Guid.NewGuid();
           FechaDeVenta = fechaDeVenta;
           ValorProducto = valorProducto;
           CantidadDeProductos = cantidadDeProductos;
           Vendedor = vendedor;
           Comprador = comprador;
           TiempoGarantiaFUncionalidades = tiempoGarantiaFUncionalidades;
       }
       
       private static List<Venta> ventasRegistradas = new List<Venta>();
       public void Registrar()
       {
           ventasRegistradas.Add(this);
           Console.WriteLine($"Venta con Id {Id} registrada correctamente.");
       }
       
       public static void MostrarVentasRegistradas()
       {
           if (ventasRegistradas.Count == 0)
           {
               Console.WriteLine("No hay ventas registradas.");
               return;
           }

           foreach (var venta in ventasRegistradas)
           {
               Console.WriteLine($"Id: {venta.Id}, Fecha: {venta.FechaDeVenta}, Valor: {venta.ValorProducto}, " +
                                 $"Cantidad: {venta.CantidadDeProductos}, Vendedor: {venta.Vendedor}, Comprador: {venta.Comprador}, " +
                                 $"Garantía: {venta.TiempoGarantiaFUncionalidades}");
           }
       }
       
       public static float VentaEspecifica(Guid id)
       {
           foreach (var venta in ventasRegistradas)
           {
               if (venta.Id == id)
               {
                   var operation = venta.ValorProducto * venta.CantidadDeProductos;
                   return operation;
               }
           }
           return 0;
       }

       public static void VentasDiarias(DateOnly fechaDeVenta)
       {
           foreach (var venta in ventasRegistradas)
           {
               if (fechaDeVenta == venta.FechaDeVenta)
               {
                   
               }
           }
       }
}