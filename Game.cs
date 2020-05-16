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

            board.FirstTurn();
        }
        public void Play()
        {
            do
            {
                // Mostra o board
                UI.DisplayBoard(board);

                // Fazemos a jogada

                board.Move();

            }while(board.Finished() == false);
                

            // Mostra o tabuleiro final

            UI.DisplayBoard(board); 

            // Indica o resultado final 
        }
    }
}