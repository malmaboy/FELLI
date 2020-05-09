using System;

namespace Felli
{
    // Apenas console Writelines e readlines
    public class UserInterface 
    {
        public void DisplayBoard(Board board)
        {
            string VerticalSymbol = "| "; // simbolo vertical do board
            string DiagonalSymbol = "---+---+---"; // simbolo diagonal do board
            string HorizontalSymbol = "------------";

           /* for(int lines = 0; lines < 2; lines++)
            {
                for(int col = 0; col < states[lines].Length; col++) // erro aqui, devia chamar a variavel states
                {
                   switch (board.GetState(lines,col))
                   {
                       case State.B:
                            Console.Write(" B "); // Peças pretas
                            break;
                        case State.W:
                            Console.Write(" W "); // Peças brancas
                            break;
                        case State.Undecided:
                            Console.Write("  "); // Espaço vazio 
                            break;
                   }
                   Console.WriteLine(VerticalSymbol);
                }
                Console.WriteLine(DiagonalSymbol);
            }   */

            // uma solução para o problema
            for(int lines = 0; lines < 2; lines++)
            {
                for(int col = 0; col < 3; col++)
                {
                    switch (board.GetState(lines,col))
                   {
                       case State.B:
                            Console.Write(" B "); // Peças pretas
                            break;
                        case State.W:
                            Console.Write(" W "); // Peças brancas
                            break;
                        case State.Undecided:
                            Console.Write("  "); // Espaço vazio 
                            break;
                   }
                   Console.WriteLine(VerticalSymbol);
                }
            }
                switch (board.GetState(2,0))
                {
                    case State.B:
                        Console.Write(" B "); // Peças pretas
                        break;
                    case State.W:
                        Console.Write(" W "); // Peças brancas
                        break;
                    case State.Undecided:
                        Console.Write("  "); // Espaço vazio 
                        break;
                }
            for(int lines = 0; lines < 2; lines++)
            {
                for(int col = 0; col < 3; col++)
                {
                    switch (board.GetState(lines,col))
                   {
                       case State.B:
                            Console.Write(" B "); // Peças pretas
                            break;
                        case State.W:
                            Console.Write(" W "); // Peças brancas
                            break;
                        case State.Undecided:
                            Console.Write("  "); // Espaço vazio 
                            break;
                   }
                   Console.WriteLine(VerticalSymbol);
                }
            }
        }  
    }
}
                
                
                

        


