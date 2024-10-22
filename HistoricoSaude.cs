namespace PETSAFE_2._0
{
    public class HistoricoSaude
    {
        //public int IDHistoricoSaude { get; set; }
        public int IDPet { get; set; }
        public string Descricao { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Tipo { get; set; }
        public byte[] Documento { get; set; }  // Documento em formato binário
        public DateTime DataCriacao { get; set; }
    }
}
