using CadastroSimples;

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Buscar usuário por nome");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1": //Se opção selecionada for 1, irá iniciar um cadastro
                    var novoUsuario = Crud.CadastrarUsuario();
                    if (novoUsuario != null)
                        usuarios.Add(novoUsuario);
                    break;
                case "2": //Se opção selecionada for 2, será exibida uma lista de usuários cadastrados
                    Crud.ListarUsuarios(usuarios);
                    break;
                case "3": //Se a opção selecionada for 3, deve-se escrever um nome para fazer a busca
                    Crud.BuscarUsuario(usuarios);
                    break;
                case "4": //Se a opção selecionada for 4, encerra-se a aplicação
                    return;
                default: //Caso não selecione nenhuma das anteriores, será exibido a mensagem abaixo
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }


}
