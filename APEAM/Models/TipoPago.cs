namespace ExamenAPEAM.Models
{
    public class TipoPago
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<RegistroTransaccion> Transacciones { get; set; }
    }
}
