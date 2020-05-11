using System;

namespace Felli
{
    // Apenas console Writelines e readlines
    public class UserInterface 
    {
        
        
        public void DisplayBoard(Board board)
        {
            string VerticalSymbol = "| "; // simbolo vertical do board
<<<<<<< HEAD
            string DiagonalSymbolUp = "_____\\__________________________/______"; // simbolo diagonal do board
            string DiagonalSymbol1Up = "______________\\__________/_____________";
            string DiagonalSymbolDown = "_____/__________________________\\______"; // simbolo diagonal do board
            string DiagonalSymbol1Down = "______________/__________\\_____________";
=======
            string DiagonalSymbol = "_____/__________________________/______"; // simbolo diagonal do board
            string DiagonalSymbol1 = "_____________/_____________/___________";
>>>>>>> parte_1
            string HorizontalSymbol = "-----------"; // simbolo horizontal
            string HorizontalSymbol1 = "-----";
            

<<<<<<< HEAD
            for(int lines = 0; lines < Board.GetBoardLL(); lines++)
=======
            for(int lines = 0; lines < Board.states.Length; lines++)
>>>>>>> parte_1
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
<<<<<<< HEAD
                for(int col = 0; col < Board.GetBoardLC(lines); col++) 
=======
                for(int col = 0; col < Board.states[lines].Length; col++) 
>>>>>>> parte_1
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
<<<<<<< HEAD
                    if ( col < Board.GetBoardLC(lines) - 1 ) // retira a barra final e imprime a linhas 
=======
                    if ( col < Board.states[lines].Length - 1 ) // retira a barra final e imprime a linhas 
>>>>>>> parte_1
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
<<<<<<< HEAD
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
                
=======
                if ( lines == 0 || lines == 3)
                {
                    System.Console.Write(DiagonalSymbol);
                }
                if ( lines == 1 || lines == 2)
                {
                    System.Console.Write(DiagonalSymbol1);
                }
>>>>>>> parte_1
                

            }
        }  
    }
}

            

            
            
                
                
                

        


