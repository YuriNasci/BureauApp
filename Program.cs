// See https://aka.ms/new-console-template for more information

using BourealApp.Models;
using BureauApp.Models;
using BureauApp.Services;
using System.Xml.Linq;

# region RNF1
while (true) {
    Console.WriteLine("Login:");
    var login = Console.ReadLine();
    Console.WriteLine("Senha:");
    var senha = ConsoleRemix.ReadPassword();

    CredencialService credencialService = new CredencialService();
    var usuario = credencialService.Logar(login ?? String.Empty, senha);
    if (usuario != null)
    {
        Console.WriteLine("Menu: ");

        if (usuario.GetType() == typeof(UsuarioAdm))
        {
            Console.WriteLine("1 - Encerrar Sessão");
            Console.WriteLine("2 - Fechar Aplicação");
            var opcao = Console.ReadLine();
            if (opcao == "1")
            {
                continue;
            } else if (opcao == "2")
            {
                break;
            }
        } else
        {
            Console.WriteLine("1 - Encerrar Sessão");
            Console.WriteLine("2 - Fechar Aplicação");
            var opcao = Console.ReadLine();
            if (opcao == "1")
            {
                continue;
            }
            else if (opcao == "2")
            {
                break;
            }
        }
    } else
    {
        Console.WriteLine("Usuário ou senha inválido.");
    }
}
#endregion


