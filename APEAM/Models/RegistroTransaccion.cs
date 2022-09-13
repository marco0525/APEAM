namespace ExamenAPEAM.Models
{
    public class RegistroTransaccion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdTipoPago { get; set; }
        public string Accion { get; set; }
        public int Cantidad { get; set; }
        public float CostoUnitario { get; set; }
        public float Total { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual TipoPago TipoPago { get; set; }
    }
}
