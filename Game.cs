using System;
namespace Felli
{
    public class Game
    {
        private Board board;
        private UserInterface UI;

        public Game()
        {
            board = new Board();
            UI = new UserInterface();
        }
        public void Play()
        {
            do
            {
                // Mostra o board
                UI.DisplayBoard(board);

                // Pede Input ao jogador
                Console.ReadLine();

                // Fazemos a jogada


            }while(!board.Finished);
                

            // Mostra o tabuleiro final 

            // Indica o resultado final 
        }
    }
}