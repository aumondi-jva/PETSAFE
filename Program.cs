namespace PETSAFE_2._0
{
    public class Program
    {
        static void Main(string[] args)
        {
            PetSafe petSafe = new PetSafe();
            while (true)
            {
                Console.WriteLine("\n=== MENU PETSAFE ===");
                Console.WriteLine("1. Cadastrar Usuário");
                Console.WriteLine("2. Cadastrar Pet");
                Console.WriteLine("3. Cadastrar Lembrete");
                Console.WriteLine("4. Cadastrar Histórico de Saúde");
                Console.WriteLine("5. Cadastrar Controle de Peso");
                Console.WriteLine("6. Cadastrar Diário Alimentar");
                Console.WriteLine("7. Cadastrar Agendamento");
                Console.WriteLine("8. Cadastrar Coleira de Rastreamento");
                Console.WriteLine("9. Cadastrar Histórico de Localização");
                Console.WriteLine("10. Cadastrar Zona Segura");
                Console.WriteLine("11. Lista de pets");
                Console.WriteLine("12. Lista de usuarios");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        petSafe.CadastrarUsuario();
                        Console.WriteLine($"Usuário cadastrado com sucesso!");
                        break;
                    case "2":
                        petSafe.CadastrarPet();
                        Console.WriteLine($"Pet cadastrado com sucesso!");
                        break;
                    case "3":
                        petSafe.CadastrarLembrete();
                        Console.WriteLine("Lembrete cadastrado com sucesso!");
                        break;
                    case "4":
                        petSafe.CadastrarHistoricoSaude();
                        Console.WriteLine("Histórico de saúde cadastrado com sucesso!");
                        break;
                    case "5":
                        petSafe.CadastrarControlePeso();
                        Console.WriteLine("Controle de peso cadastrado com sucesso!");
                        break;
                    case "6":
                        petSafe.CadastrarDiarioAlimentar();
                        Console.WriteLine("Diário alimentar cadastrado com sucesso!");
                        break;
                    case "7":
                        petSafe.CadastrarAgendamento();
                        Console.WriteLine("Agendamento cadastrado com sucesso!");
                        break;
                    case "8":
                        petSafe.CadastrarColeiraRastreamento();
                        Console.WriteLine("Coleira de rastreamento cadastrada com sucesso!");
                        break;
                    case "9":
                        petSafe.CadastrarHistoricoLocalizacao();
                        Console.WriteLine("Histórico de localização cadastrado com sucesso!");
                        break;
                    case "10":
                        petSafe.CadastrarZonaSegura();
                        Console.WriteLine("Zona segura cadastrada com sucesso!");
                        break;
                    case "11":
                        petSafe.ListaPet();
                        break;
                    case "12":
                        petSafe.ListaUsuario();
                        break;
                    case "0":
                        Console.WriteLine("Saindo do sistema...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
    
}
