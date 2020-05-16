using System;
namespace Felli
{
    /// <summary>
    /// Classe que modifica o tabuleiro, gera jogadas e verifica a vitória.
    /// </summary>
    public class Board
    {

        private static State[][] states;         
        private int countB;
        private int countW;
        private char turn;
        private int line;
        private int col;
        private UserInterface Ui;
        private Board board;


        /// <summary>
        /// Escolhe qual o jogador que joga primeiro as peças brancas
        /// ou pretas.
        /// </summary>
        public void FirstTurn()
        {
            Ui = new UserInterface();
            board = new Board();

            Ui.PlayerChoice(board);

            turn = Console.ReadKey().KeyChar;

        }
        
        /// <summary>
        /// Verifica se os requirimentos para o jogo acabar 
        /// foram alcançados.
        /// </summary>
        /// <returns>Retorna true se o jogo acabar, caso contrário 
        /// retorna false.</returns>
        public bool Finished()
        {
            countB = 0;

            countW = 0;

            for (line = 0; line < 5 ; line++)
            {
                for (col = 0; col < 3 ; col++)
                {
                    if (line == 2)
                    {
                        if (states[2][0] == State.B)
                        {
                            countB++;
                        }

                        if (states[2][0] == State.W)
                        {
                            countW++;
                        }
                    }

                    else
                    {
                        if (states[line][col] == State.B)
                        {
                            countB++;
                        }

                        if (states[line][col] == State.W)
                        {
                            countW++;
                        }
                    }   

                }
            }

            if (countB == 0 || countW == 0) 
            {
                return true;
            }

            return false;
            
        }
        /// <summary>
        /// Cria o estado do board inicial.
        /// </summary>
        public Board()
        {
            states = new State[5][];
            states[0] = new State[3];
            states[1] = new State[3];
            states[2] = new State[1];
            states[3] = new State[3];
            states[4] = new State[3];
            countB = 0;
            countW = 0;
        
            for (int i = 0; i< 2;i++){

                for (int j = 0; j < states[i].Length; j++)
                {
                    states[i][j] = State.B;
                }
            }
            for (int i = 3; i< 5;i++){

                for (int j = 0; j < states[i].Length; j++)
                {
                    states[i][j] = State.W;
                }
            }
        }
        /// <summary>
        /// Verifica qual o estado de um ponto específico do board.
        /// </summary>
        /// <param name="x">Número da linha a ver.</param>
        /// <param name="y">Número da coluna a ver.</param>
        /// <returns></returns>
        public State GetState(int x, int y)
        {
            return states[x][y];
        }
        /// <summary>
        /// Verifica quantas linhas tem o array.
        /// </summary>
        /// <returns>O número de linhas (tamanho do array).</returns>
        public static int GetBoardLL()
        {
            return states.Length;
        }
        /// <summary>
        /// Verifica quantas colunas tem cada linha do array.
        /// </summary>
        /// <param name="x">Linha a ser verificada</param>
        /// <returns>O número de colunas numa certa linha do array</returns>
        public static int GetBoardLC(int x)
        {
            return states[x].Length;
        }
        /// <summary>
        /// Movimenta as peças no board.
        /// </summary>
        public void Move()
        {
            Ui = new UserInterface();
            board = new Board();

            Ui.FirstPos(board);
            Ui.Lines(board);
            int l1 = Int32.Parse(Console.ReadLine());
            Ui.Col(board);
            int c1 = Int32.Parse(Console.ReadLine());

            Ui.MovePos(board);
            Ui.Lines(board);
            int l2 = Int32.Parse(Console.ReadLine());
            Ui.Col(board);
            int c2 = Int32.Parse(Console.ReadLine());

            if ( turn == 'b')
            {
                if ( states[l1][c1] == State.B && states[l2][c2] == State.Empty)
                {
                    states[l1][c1] = State.Empty;
                    states[l2][c2] = State.B;
                    turn = 'w';

                    if (l1 + 2 == l2||c1 + 2 == c2||l1 - 2 == l2||c1 - 2 == c2)
                    {
                        if ( l1 == 0 )
                        {
                            if ( l1 + 2 == l2)
                            {
                                states[l1+1][c1] = State.Empty;
                            }

                            if ( c1 + 2 == c2)
                            {
                                states[l1][c1+1] = State.Empty;
                            }

                            if ( c1 - 2 == c2)
                            {
                                states[l1][c1-1] = State.Empty;
                            }
                        }

                        if ( l1 == 1)
                        {
                            if ( l2 == 3)
                            {
                                states[2][0] = State.Empty;
                            }

                            else
                            {
                                if (c2 != 0)
                                {
                                    if (c1 + 2 == c2 || c1 -2 == c2)
                                    {
                                        states[1][1] = State.Empty;
                                    }
                                }
                            }
                        }

                        if ( l1 == 2)
                        {
                            if ( l2 == 0)
                            {
                                if ( c2 == 0)
                                {
                                    states[1][0] = State.Empty;
                                }

                                if ( c2 == 1)
                                {
                                    states[1][1] = State.Empty;
                                }

                                if ( c2 == 2)
                                {
                                    states[1][2] = State.Empty;
                                }
                            }

                            if ( l2 == 4)
                            {
                                if ( c2 == 0)
                                {
                                    states[3][0] = State.Empty;
                                }

                                if ( c2 == 1)
                                {
                                    states[3][1] = State.Empty;
                                }

                                if ( c2 == 2)
                                {
                                    states[3][2] = State.Empty;
                                }
                            }
                        }

                        if ( l1 == 3)
                        {
                            if ( l2 == 1)
                            {
                                states[2][0] = State.Empty;
                            }

                            else
                            {
                                if (c1 + 2 == c2 || c1 -2 == c2)
                                {
                                    states[3][1] = State.Empty;
                                }
                            }
                        }

                        if ( l1 == 4 )
                        {
                            if ( l1 - 2 == l2)
                            {
                                states[l1-1][c1] = State.Empty;
                            }

                            if ( c1 + 2 == c2)
                            {
                                states[l1][c1+1] = State.Empty;
                            }

                            if ( c1 - 2 == c2)
                            {
                                states[l1][c1-1] = State.Empty;
                            }
                        }
                    }
                }

                else
                {
                    Ui.InvMessage(board);   
                }

            }

            else
            {
                if ( states[l1][c1] == State.W && states[l2][c2] == State.Empty)
                {
                    states[l1][c1] = State.Empty;
                    states[l2][c2] = State.W;
                    turn = 'b';
                    
                    if (l1 + 2 == l2||c1 + 2 == c2||l1 - 2 == l2||c1 - 2 == c2)
                    {
                        if ( l1 == 0 )
                        {
                            if ( l1 + 2 == l2)
                            {
                                states[l1+1][c1] = State.Empty;
                            }

                            if ( c1 + 2 == c2)
                            {
                                states[l1][c1+1] = State.Empty;
                            }

                            if ( c1 - 2 == c2)
                            {
                                states[l1][c1-1] = State.Empty;
                            }
                        }

                        if ( l1 == 1)
                        {
                            if ( l2 == 3)
                            {
                                states[2][0] = State.Empty;
                            }

                            else
                            {
                                if (c2 != 0)
                                {
                                    if (c1 + 2 == c2 || c1 -2 == c2)
                                    {
                                        states[1][1] = State.Empty;
                                    }
                                }
                            }
                        }

                        if ( l1 == 2)
                        {
                            if ( l2 == 0)
                            {
                                if ( c2 == 0)
                                {
                                    states[1][0] = State.Empty;
                                }

                                if ( c2 == 1)
                                {
                                    states[1][1] = State.Empty;
                                }

                                if ( c2 == 2)
                                {
                                    states[1][2] = State.Empty;
                                }
                            }

                            if ( l2 == 4)
                            {
                                if ( c2 == 0)
                                {
                                    states[3][0] = State.Empty;
                                }

                                if ( c2 == 1)
                                {
                                    states[3][1] = State.Empty;
                                }

                                if ( c2 == 2)
                                {
                                    states[3][2] = State.Empty;
                                }
                            }
                        }

                        if ( l1 == 3)
                        {
                            if ( l2 == 1)
                            {
                                states[2][0] = State.Empty;
                            }

                            else
                            {
                                if (c1 + 2 == c2 || c1 -2 == c2)
                                {
                                    states[3][1] = State.Empty;
                                }
                            }
                        }

                        if ( l1 == 4 )
                        {
                            if ( l1 - 2 == l2)
                            {
                                states[l1-1][c1] = State.Empty;
                            }

                            if ( c1 + 2 == c2)
                            {
                                states[l1][c1+1] = State.Empty;
                            }

                            if ( c1 - 2 == c2)
                            {
                                states[l1][c1-1] = State.Empty;
                            }
                        }
                    }
                }

                else
                {
                    Ui.InvMessage(board);    
                }
            }
            
        }




        
      
    }
}
