using GameHub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.View {
    public class PessoaView {

        public static Usuario MenuNovoCadastro()
        {
            Console.WriteLine("Vamos cadastrar um novo usuário");
            Console.Write("Digite o seu usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine("Usuário cadastrado com sucesso");
            Console.WriteLine("Pressione qualquer tecla...");
            Console.ReadKey();                                   
            Console.Clear();            
            return new Usuario(nome, senha);
        }

        public static bool MenuLogin()
        {
            Console.WriteLine("Digite o seu usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();
            Usuario usuario = new Usuario(nome, senha);
            if (usuario.Autenticar())
            {
                Console.WriteLine("Login realizado com sucesso");
                Console.WriteLine("Pressione qualquer tecla...");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos");
                Console.WriteLine("Pressione qualquer tecla...");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
        }

    }
}


