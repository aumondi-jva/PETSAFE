using PETSAFE_2._0;

namespace PETSAFE_2._0
{
    public class PetSafe
    {
        List<Pet> pets = new List<Pet>();
        List<Usuario> listausuarios = new List<Usuario>();
        public void LimparTela()
        {
            Console.Clear();
            Console.ReadKey();
        }
        public void CadastrarUsuario()
        {

            Usuario usuario = new Usuario();

            Console.Clear();

            Console.WriteLine("Informe o nome do usuário:");
            usuario.Nome = Console.ReadLine();

            Console.WriteLine("Informe o email:");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Informe a senha:");
            usuario.Senha = Console.ReadLine();

            Console.WriteLine("Informe o telefone:");
            usuario.Telefone = Console.ReadLine();

            Console.WriteLine("Informe o endereço:");
            usuario.Endereco = Console.ReadLine();

            usuario.DataCriacao = DateTime.Now;

            listausuarios.Add(usuario);

            LimparTela();
        }

        public void CadastrarRecuperacaoSenha()
        {
            RecuperacaoSenha recuperacaoSenha = new RecuperacaoSenha();

            Console.WriteLine("Informe o ID do usuário:");
            recuperacaoSenha.IDUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o token:");
            recuperacaoSenha.Token = Console.ReadLine();

            Console.WriteLine("Informe a data de expiração (formato: yyyy-mm-dd hh:mm:ss):");
            recuperacaoSenha.Expiracao = DateTime.Parse(Console.ReadLine());

            recuperacaoSenha.Usado = false;  // Definido como falso por padrão

            LimparTela();
        }

        public void CadastrarPet()
        {
            Pet pet = new Pet();

            Console.Clear();


            Console.WriteLine("Informe o ID do usuário:");
            pet.IDUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do pet:");
            pet.Nome = Console.ReadLine();

            Console.WriteLine("Informe a raça do pet:");
            pet.Raca = Console.ReadLine();

            Console.WriteLine("Informe a idade do pet:");
            pet.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso do pet:");
            pet.Peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a foto do pet (em formato byte):");
            pet.Foto = new byte[0];  // Aqui, você precisaria implementar um método para converter a imagem para byte[]

            pet.DataCadastro = DateTime.Now;

            pets.Add(pet);

            LimparTela();
        }

        public void CadastrarLembrete()
        {
            Lembrete lembrete = new Lembrete();

            Console.WriteLine("Informe o ID do pet:");
            lembrete.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo do lembrete:");
            lembrete.Tipo = Console.ReadLine();

            Console.WriteLine("Informe a descrição:");
            lembrete.Descricao = Console.ReadLine();

            Console.WriteLine("Informe a data do lembrete (formato: yyyy-mm-dd hh:mm:ss):");
            lembrete.DataLembrete = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Repetir lembrete? (S/N):");
            lembrete.Repetir = Console.ReadLine().ToUpper() == "S";

            lembrete.DataCriacao = DateTime.Now;

            LimparTela();
        }

        public void CadastrarHistoricoSaude()
        {
            HistoricoSaude historicoSaude = new HistoricoSaude();

            Console.WriteLine("Informe o ID do pet:");
            historicoSaude.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a descrição do histórico de saúde:");
            historicoSaude.Descricao = Console.ReadLine();

            Console.WriteLine("Informe a data de registro (formato: yyyy-mm-dd):");
            historicoSaude.DataRegistro = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de histórico de saúde:");
            historicoSaude.Tipo = Console.ReadLine();

            Console.WriteLine("Informe o documento (em formato byte):");
            historicoSaude.Documento = new byte[0]; 

            historicoSaude.DataCriacao = DateTime.Now;

            LimparTela();
        }

        public void CadastrarControlePeso()
        {
            ControlePeso controlePeso = new ControlePeso();

            Console.WriteLine("Informe o ID do pet:");
            controlePeso.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso do pet:");
            controlePeso.Peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a data de registro (formato: yyyy-mm-dd):");
            controlePeso.DataRegistro = DateTime.Parse(Console.ReadLine());

            controlePeso.DataCriacao = DateTime.Now;

            LimparTela();
        }

        public void CadastrarDiarioAlimentar()
        {
            DiarioAlimentar diarioAlimentar = new DiarioAlimentar();

            Console.WriteLine("Informe o ID do pet:");
            diarioAlimentar.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a refeição:");
            diarioAlimentar.Refeicao = Console.ReadLine();

            Console.WriteLine("Informe a data da refeição (formato: yyyy-mm-dd):");
            diarioAlimentar.DataRefeicao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe a observação (opcional):");
            diarioAlimentar.Observacao = Console.ReadLine();

            diarioAlimentar.DataCriacao = DateTime.Now;

            LimparTela();
        }

        public void CadastrarAgendamento()
        {
            Agendamento agendamento = new Agendamento();

            Console.WriteLine("Informe o ID do pet:");
            agendamento.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de serviço:");
            agendamento.TipoServico = Console.ReadLine();

            Console.WriteLine("Informe a data do agendamento (formato: yyyy-mm-dd hh:mm:ss):");
            agendamento.DataAgendamento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe a localização:");
            agendamento.Localizacao = Console.ReadLine();

            agendamento.DataCriacao = DateTime.Now;

            LimparTela();
        }

        public void CadastrarColeiraRastreamento()
        {
            ColeiraRastreamento coleiraRastreamento = new ColeiraRastreamento();

            Console.WriteLine("Informe o ID do pet:");
            coleiraRastreamento.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o status de conectividade:");
            coleiraRastreamento.StatusConectividade = Console.ReadLine();

            Console.WriteLine("Informe o nível de bateria:");
            coleiraRastreamento.NivelBateria = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a localização atual:");
            coleiraRastreamento.LocalizacaoAtual = Console.ReadLine();  

            coleiraRastreamento.DataAtualizacao = DateTime.Now;

            LimparTela();
        }
        public void CadastrarHistoricoLocalizacao()
        {
            HistoricoLocalizacao historicoLocalizacao = new HistoricoLocalizacao();

            Console.WriteLine("Informe o ID do pet:");
            historicoLocalizacao.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a localização:");
            historicoLocalizacao.Localizacao = Console.ReadLine();  

            Console.WriteLine("Informe a data de registro (formato: yyyy-mm-dd hh:mm:ss):");
            historicoLocalizacao.DataRegistro = DateTime.Parse(Console.ReadLine());

            LimparTela();
        }

        public void CadastrarZonaSegura()
        {
            ZonaSegura zonaSegura = new ZonaSegura();

            Console.WriteLine("Informe o ID do pet:");
            zonaSegura.IDPet = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome da zona segura:");
            zonaSegura.Nome = Console.ReadLine();

            Console.WriteLine("Informe a localização da zona:");
            zonaSegura.Localizacao = Console.ReadLine();  // String ou objeto de geolocalização

            Console.WriteLine("Informe o raio da zona segura:");
            zonaSegura.Raio = decimal.Parse(Console.ReadLine());

            zonaSegura.DataCriacao = DateTime.Now;

            LimparTela();
        }

        public void ListaPet()
        {
            Console.Clear();

            foreach (var pt in pets)
            {
                Console.WriteLine();
                Console.WriteLine($"ID do usuario: {pt.IDUsuario} ");
                Console.WriteLine($"Nome do pet: {pt.Nome} ");
                Console.WriteLine($"Raca do pet: {pt.Raca} ");
                Console.WriteLine($"Idade do pet: {pt.Idade} ");
                Console.WriteLine($"Peso do pet: {pt.Peso} ");
            }
        }

        public void ListaUsuario()
        {
            Console.Clear();    

            foreach (var user in listausuarios)
            {
                Console.WriteLine();
                Console.WriteLine($"ID do usuario: {user.IDUsuario} ");
                Console.WriteLine($"Nome do usuario: {user.Nome} ");
                Console.WriteLine($"Email do usuario: {user.Email} ");
                Console.WriteLine($"Telefone do usuario: {user.Telefone} ");
                Console.WriteLine($"Endereco do usuario: {user.Endereco} ");
                Console.WriteLine($"Data do cadastro do usuario: {user.DataCriacao} ");
            }
        }
    }
}
