using GameHub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub.Model
{
    public class MenuJogos
    {
        
        public void HubMenuJogos()
        {                    
        int opcaoJogos;
            do
            {
                Console.Clear();
                Console.Write("Selecione um dos jogos disponíveis: \n" +
                                  "Jogo da Velha ------------------ (1)\n" +
                                  "Batalha Naval ------------------ (2)\n" +
                                  "Voltar ao menu anterior -------- (3)\n");
                opcaoJogos = int.Parse(Console.ReadLine());
                switch (opcaoJogos)
                {
                    case 1:
                        JogoDaVelha jogoDaVelha = new JogoDaVelha();
                        jogoDaVelha.AJogoDaVelha();                        
                        break;
                    case 2:
                        BatalhaNaval batalhaNaval = new BatalhaNaval();
                        batalhaNaval.JogoBatalhaNaval();
                        break;
                    case 3:
                                              
                        break;
                }
            } while (opcaoJogos != 3);

        }
    }
}
