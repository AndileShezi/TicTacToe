using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()



        {
            



            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);

            Console.Write("Player 1");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row (0 to 2): ");
            var rowX = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column(0 to 2): ");
            var columnX = Console.ReadLine();


            _boardRenderer.AddMove(int.Parse(rowX), int.Parse(columnX), PlayerEnum.X, true);



            //player2

            Console.SetCursorPosition(32, 19);

            Console.Write("Player 2");

            Console.SetCursorPosition(32, 20);

            Console.Write("Please Enter Row (0 to 2): ");
            var rowY = Console.ReadLine();

            Console.SetCursorPosition(32, 22);


            Console.Write("Please Enter Column(0 to 2): ");
            var columnY = Console.ReadLine();

            _boardRenderer.AddMove(int.Parse(rowY), int.Parse(columnY), PlayerEnum.O, true);

        }

    }
}
