namespace PETSAFE_2._0
{
    public class ColeiraRastreamento
    {
        //public int IDColeiraRastreamento { get; set; }
        public int IDPet { get; set; }
        public string StatusConectividade { get; set; }
        public decimal NivelBateria { get; set; }
        public string LocalizacaoAtual { get; set; }  // Dependendo do formato, você pode usar uma classe de geolocalização
        public DateTime DataAtualizacao { get; set; }
    }
}
