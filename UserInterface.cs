using System;

namespace Felli
{
    // Apenas console Writelines e readlines
    public class UserInterface 
    {
        
        
        public void DisplayBoard(Board board)
        {
            string VerticalSymbol = "| "; // simbolo vertical do board
            string DiagonalSymbolUp = "_____\\__________________________/______"; // simbolo diagonal do board
            string DiagonalSymbol1Up = "______________\\__________/_____________";
            string DiagonalSymbolDown = "_____/__________________________\\______"; // simbolo diagonal do board
            string DiagonalSymbol1Down = "______________/__________\\_____________";
            string HorizontalSymbol = "-----------"; // simbolo horizontal
            string HorizontalSymbol1 = "-----";
            string Positions 
            = "\n posições(x,y): \n (01);(02);(03)\n (10);(11);(12)\n (20)\n (30);(31);(32)\n (40);(41);(42)\n";
            
            System.Console.WriteLine(Positions);
            for(int lines = 0; lines < Board.GetBoardLL(); lines++)
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
                for(int col = 0; col < Board.GetBoardLC(lines); col++) 
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
                        case State.Empty:
                            Console.Write("  "); // Espaço vazio 
                            break;
                   }
                    System.Console.Write(VerticalSymbol);
                    if ( col < Board.GetBoardLC(lines) - 1 ) // retira a barra final e imprime a linhas 
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
                if ( lines == 0)
                {
                    System.Console.Write(DiagonalSymbolUp);
                }
                if ( lines == 1)
                {
                    System.Console.Write(DiagonalSymbol1Up);
                }
                if ( lines == 2)
                {
                    System.Console.Write(DiagonalSymbol1Down);
                }
                if ( lines == 3)
                {
                    System.Console.Write(DiagonalSymbolDown);
                }

                
                
                

            }
        }  
    }
}

            

            
            
                
                
                

        


