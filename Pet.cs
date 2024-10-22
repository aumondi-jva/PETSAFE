namespace PETSAFE_2._0
{
    public class Pet
    {
        public int IDPet { get; set; }
        public int IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public byte[] Foto { get; set; }  // Para armazenar imagem em byte array
        public DateTime DataCadastro { get; set; }
    }
}
