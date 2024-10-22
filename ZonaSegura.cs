namespace PETSAFE_2._0
{
    public class ZonaSegura
    {
        //public int IDZonaSegura { get; set; }
        public int IDPet { get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }  // Geolocalização
        public decimal Raio { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
