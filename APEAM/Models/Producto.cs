namespace ExamenAPEAM.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<RegistroTransaccion> Transacciones { get; set; }

    }
}
