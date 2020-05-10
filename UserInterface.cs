using System;

namespace Felli
{
    // Apenas console Writelines e readlines
    public class UserInterface 
    {
        
        
        public void DisplayBoard(Board board)
        {
            string VerticalSymbol = "| "; // simbolo vertical do board
            string DiagonalSymbol = "_____/__________________________/______"; // simbolo diagonal do board
            string DiagonalSymbol1 = "_____________/_____________/___________";
            string HorizontalSymbol = "-----------"; // simbolo horizontal
            string HorizontalSymbol1 = "-----";
            

            for(int lines = 0; lines < Board.states.Length; lines++)
            {
                System.Console.WriteLine();
                if (lines == 1 || lines == 3)
                {
                    System.Console.Write("______");
                }
                if ( lines == 2)
                {
                    System.Console.Write("_________________");
                }
                for(int col = 0; col < Board.states[lines].Length; col++) 
                {
                    System.Console.Write(VerticalSymbol);
                   switch (board.GetState(lines,col))
                   {
                       case State.B:
                            Console.Write("B "); // Peças pretas
                            break;
                        case State.W:
                            Console.Write("W "); // Peças brancas
                            break;
                        case State.Undecided:
                            Console.Write("  "); // Espaço vazio 
                            break;
                   }
                    System.Console.Write(VerticalSymbol);
                    if ( col < Board.states[lines].Length - 1 ) // retira a barra final e imprime a linhas 
                    {
                        if( lines == 0 || lines == 4 )
                        {
                            System.Console.Write(HorizontalSymbol);
                        }
                        if( lines == 1 || lines == 3 )
                        {
                            System.Console.Write(HorizontalSymbol1);
                        }
                        
                    }
                    else
                    {
                        if (lines == 1 || lines == 3)
                        {
                            System.Console.Write("_____");
                        }
                        if ( lines == 2)
                        {
                            System.Console.Write("________________");
                        }
                    }
                    
                }
                System.Console.WriteLine();   
                if ( lines == 0 || lines == 3)
                {
                    System.Console.Write(DiagonalSymbol);
                }
                if ( lines == 1 || lines == 2)
                {
                    System.Console.Write(DiagonalSymbol1);
                }
                

            }
        }  
    }
}

            

            
            
                
                
                

        


