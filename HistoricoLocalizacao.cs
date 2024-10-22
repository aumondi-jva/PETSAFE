namespace PETSAFE_2._0
{
    public class HistoricoLocalizacao
    {
        //public int IDHistoricoLocalizacao { get; set; }
        public int IDPet { get; set; }
        public string Localizacao { get; set; }  // A geolocalização como string ou coordenadas
        public DateTime DataRegistro { get; set; }
    }
}
