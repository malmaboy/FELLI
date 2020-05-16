using System;
namespace Felli
{
    ///
    /// Classe responsável por instanciar o tabuleiro e o UI e gerir
    /// o andamento do jogo.
    ///
    public class Game
    {
        private Board board;
        private UserInterface UI;

        ///
        /// Instancia o tabuleiro e o UI
        /// 
        public Game()
        {
            board = new Board();
            UI = new UserInterface();

            board.FirstTurn();
        }
        ///
        /// Inicializa o jogo
        ///
        
        public void Play()
        {
            do
            {
                // Mostra o tabuleiro
                UI.DisplayBoard(board);

                // Fazemos a jogada

                board.Move();

            }while(board.Finished() == false);
                

            // Mostra o tabuleiro final

            UI.DisplayBoard(board);  
        }
    }
}
