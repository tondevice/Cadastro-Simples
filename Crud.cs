namespace CadastroSimples
{
    public static class Crud
    {
        // Método para cadastrar um novo usuário
        public static Usuario CadastrarUsuario()
        {
            // Solicita ao usuário que digite seu nome
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            // Solicita o e-mail do usuário
            Console.Write("Digite o e-mail: ");
            string email = Console.ReadLine();

            // Solicita a idade e valida se é um número inteiro válido
            Console.Write("Digite a idade: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Usuário cadastrado com sucesso!");
                // Retorna um novo objeto do tipo Usuario com os dados preenchidos
                return new Usuario() { Nome = nome, Email = email, Idade = idade };
            }
            else
            {
                Console.WriteLine("Idade inválida!");
                // Retorna null caso a idade digitada não seja um número válido
                return null;
            }
        }

        // Método para listar todos os usuários cadastrados
        public static void ListarUsuarios(List<Usuario> usuarios)
        {
            // Verifica se a lista de usuários está vazia
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            Console.WriteLine("\nLista de usuários cadastrados:");
            // Percorre a lista e exibe os dados de cada usuário
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}, Idade: {usuario.Idade}");
            }
        }

        // Método para buscar um usuário pelo nome
        public static void BuscarUsuario(List<Usuario> usuarios)
        {
            Console.Write("Digite o nome do usuário que deseja buscar: ");
            string nomeBusca = Console.ReadLine();

            // Procura um usuário na lista que tenha o nome igual ao digitado, ignorando maiúsculas e minúsculas
            Usuario usuarioEncontrado = usuarios.Find(u => u.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));

            if (usuarioEncontrado != null)
            {
                // Exibe os dados do usuário encontrado
                Console.WriteLine($"Usuário encontrado: Nome: {usuarioEncontrado.Nome}, Email: {usuarioEncontrado.Email}, Idade: {usuarioEncontrado.Idade}");
            }
            else
            {
                // Informa que o usuário não foi encontrado
                Console.WriteLine("Usuário não encontrado.");
            }
        }
    }
}
