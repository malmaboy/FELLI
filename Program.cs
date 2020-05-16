using System;

namespace Felli
{
    /// <summary>
    /// Classe responsável por iniciar o jogo.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Play();
        }
    }
}
