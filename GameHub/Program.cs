
using GameHub.Model;
using GameHub.View;

namespace GameHub
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int opcao;
            int opcaoJogos;

            GameHubMenu menu = new GameHubMenu();
            menu.Menu();
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            do
            {
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o GameHub...Até mais!");
                        break;

                    case 1:
                        //Aqui vai o cadastro de usuário                    
                        PessoaView.MenuNovoCadastro();
                        break;

                    case 2:
                        if (PessoaView.MenuLogin())
                        {
                            MenuJogos menuDosJogos = new MenuJogos();
                            menuDosJogos.HubMenuJogos();
                        }
                        else
                        {
                            Console.Clear();
                            MenuJogos retornaMenu = new MenuJogos();
                            retornaMenu.HubMenuJogos();
                            opcao = int.Parse(Console.ReadLine());
                        }
                            break;

                    case 3:
                        //Aqui vai o ranking

                        break;
                }


            } while (opcao != 0);


        }
    }
}