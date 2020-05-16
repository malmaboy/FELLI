using System;
namespace Felli
{
    public class Board
    {

        private static State[][] states;         
        //private int turn;
        private int countB;
        private int countW;
        private char turn;
        private int line;
        private int col;

        /*private State NextTurn(int x) 
        {
            if(turn == 0){
                turn = turn + x;
            }
            if (Finished) // Se tiver terminado 
            {
                return State.Empty; // 
            }
            else if (turn % 2 == 0) // Se o turno for par joga o B (peças pretas)
            {
                return State.B;
            }
            else    // caso contrário joga o W(peças brancas)
            {
                return State.W;
            }
            
        }*/

        public void FirstTurn()
        {
            Console.WriteLine("Insira o jogador que joga primeiro (B ou W)");

            turn = Console.ReadKey().KeyChar;

        }
        

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

        public Board() // Inicializa o board com as peças pretas em cima e as brancas em baixo
        {
            states = new State[5][];
            states[0] = new State[3];
            states[1] = new State[3];
            states[2] = new State[1];
            states[3] = new State[3];
            states[4] = new State[3];
            countB = 0;
            countW = 0;
            //turn = 0;
        
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

        public State GetState(int x, int y)
        {
            return states[x][y];
        }

        public static int GetBoardLL()
        {
            return states.Length;
        }
        public static int GetBoardLC(int x)
        {
            return states[x].Length;
        }

        public void Move()
        {
            Console.WriteLine("Insira a posição da peça a movimentar.");
            int l1 = Int32.Parse(Console.ReadLine());
            int c1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nova posição da peça.");
            int l2 = Int32.Parse(Console.ReadLine());
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
                    Console.WriteLine("Movimento Inválido");   
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
                    Console.WriteLine("Movimento Inválido");   
                }
            }
            
        }




        
      
    }
}
