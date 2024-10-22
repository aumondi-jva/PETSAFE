namespace PETSAFE_2._0
{
    public class Usuario
    {
        static int idusuario = 0;
        public int IDUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCriacao { get; set; }

        public Usuario()
        {
            IDUsuario = idusuario;
            idusuario++;

        }

        
    }
}
