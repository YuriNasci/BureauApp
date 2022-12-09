// See https://aka.ms/new-console-template for more information

using BourealApp.Models;
using System.Xml.Linq;

Console.WriteLine("Login:");
var login = Console.ReadLine();
Console.WriteLine("Senha:");
var senha = ConsoleRemix.ReadPassword();

UsuarioBase usuario = new UsuarioBase();
usuario.Logar(login ?? string.Empty, senha);
