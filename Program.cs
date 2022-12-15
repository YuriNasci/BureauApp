// See https://aka.ms/new-console-template for more information

using BourealApp.Models;
using BureauApp.Controllers;
using BureauApp.Models;
using BureauApp.Services;
using System.Xml.Linq;
/*
 CHECK-LIST DE REQUISITOS:

[ ] RF1: Consultar Bureaus Externos 
[X] RF2: Cadastrar Clientes
[X] RF3: Excluir Clientes
[ ] RF4: Cadastrar Usuários Administrador
[ ] RF5: Excluir Usuários Administrador
[ ] RF6: Cadastrar Usuários Consultor
[ ] RF7: Excluir Usuários Consultor
[ ] RF8: Criar Plano de Tarifação
[ ] RF9: Criar Contrato
[ ] RF10: Editar Contrato
[X] RNF1: Autenticação de Usuário
[X] RNF2: Salvar no Banco de Dados
[ ] RNF3: Criptografia de Consultas
[ ] RNF4: Descriptografia de Consultas
[ ] RNF5: Integração com Plataformas de Crédito
[X] RNF6: Linguagem de Programação C#
 */


# region RNF1
while (true) {
    Console.WriteLine("Login:");
    var login = Console.ReadLine();
    Console.WriteLine("Senha:");
    var senha = ConsoleRemix.ReadPassword();

    BureauContext context = new BureauContext();
    CredencialService credencialService = new CredencialService(context);
    ClienteController clienteController = new ClienteController(context);

    var usuario = credencialService.Logar(login ?? String.Empty, senha);
    if (usuario != null)
    {
        string? opcao = "";
        while (opcao != "0")
        {
            Console.WriteLine("Menu: ");

            if (usuario.IsOwner)
            {
                Console.WriteLine("1 - Encerrar Sessão");
                Console.WriteLine("2 - Fechar Aplicação");
                Console.WriteLine("3 - Cadastrar Clientes");
                Console.WriteLine("4 - Excluir Clientes");
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    continue;
                }
                else if (opcao == "2")
                {
                    break;
                }

                switch (opcao)
                {
                    case "3":
                        clienteController.Criar();
                        break;
                    case "4":
                        clienteController.Excluir();
                        break;
                }
            }
            else
            {
                Console.WriteLine("0 - Sair");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    continue;
                }
                else if (opcao == "2")
                {
                    break;
                }
            }
        }
    } else
    {
        Console.WriteLine("Usuário ou senha inválido.");
    }
}
#endregion


