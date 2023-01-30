using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Model
{

    public class Usuario
    {
        public string nome;
        public string senha;
        public List<Usuario> usuariosCadastrados = new List<Usuario>();
        public Usuario(string nome, string senha)
        {
            this.nome = nome;
            this.senha = senha;
        }

        public string Nome
        {
            get { return nome; }
        }

        public bool Autenticar()
        {
            foreach(Usuario usuario in usuariosCadastrados)
            {
                if (usuario.nome == this.nome && usuario.senha == this.senha)
                {
                    return true;
                }
            }
            return false;
        }

        //TODAS AS TENTATIVAS QUE FIZ DE TENTAR CADASTRAR UM USUARIO:

        //public string Nome { get; set; } = null!;
        //public string Senha { get; set; } = null!;

        //public Usuario(string nome, string senha) {
        //    Nome = nome;
        //    Senha = Console.ReadLine();
        //}

        //public Cadastro(string nome, string senha) {
        //    Nome = nome;
        //    Senha = senha;
        //}

        //public void CadastrarUsuario(List<string> usuario, List<string> senha) {
        //    Console.WriteLine("Digite o nome de usuário desejado");
        //    usuario.Add(Console.ReadLine());
        //    Console.WriteLine("Digite uma senha");
        //    senha.Add(Console.ReadLine());
        //    Console.Clear();
        //}

    }
}
