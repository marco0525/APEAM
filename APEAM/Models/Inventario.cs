namespace ExamenAPEAM.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public int Cantidad { get; set; }
        public int UltimaTransaccion { get; set; }
        public int Accion { get; set; }
    }
}
