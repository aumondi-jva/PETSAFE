namespace PETSAFE_2._0
{
    public class RecuperacaoSenha
    {
        public int IDRecuperacao { get; set; }
        public int IDUsuario { get; set; }
        public string Token { get; set; }
        public DateTime Expiracao { get; set; }
        public bool Usado { get; set; }
    }
}
