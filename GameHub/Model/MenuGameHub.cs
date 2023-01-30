using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Model
{
    public class GameHubMenu
    {
        int opcao;
        int opcaoJogos;

        //Atributo Menu
        public void Menu()
        {
            Console.WriteLine("----- BEM  VINDO AO GAMEHUB -----");
            Console.WriteLine();
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("Cadastrar usuário ----------- (1)");
            Console.WriteLine("Selecionar jogos ------------ (2)");
            Console.WriteLine("Ranking --------------------- (3)");
            Console.WriteLine("Sair ------------------------ (0)");
        }
    }
}
