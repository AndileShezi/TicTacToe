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
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void Run()



        {

            char[] player1 = new char[9];
            char[] player2 = new char[9];

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            for (int index = 0; index < player1.Length; index++)
            {
                if (index == 0 || index % 2 == 0) ;
                {
                    Console.SetCursorPosition(2, 18);
                    Console.Write("Player 1");

                    Console.SetCursorPosition(2, 20);
                    Console.Write("Please Enter Row: ");

                    var rowX = Console.ReadLine();
                    Console.SetCursorPosition(2, 21);
                    Console.Write("Please Enter Column: ");
                    var columnX = Console.ReadLine();

                    _boardRenderer.AddMove(int.Parse(rowX), int.Parse(columnX), PlayerEnum.X, true);

                    /*     Console.SetCursorPosition(40, 18);
                         Console.Write("Player Y");

                         Console.SetCursorPosition(40, 20);
                         Console.Write("Please enter Row:");
                         var rowO = Console.ReadLine();

                         Console.SetCursorPosition(40, 21);
                         Console.Write("Please Enter Column: ");
                         var columnO = Console.ReadLine();

                         _boardRenderer.AddMove(int.Parse(rowO), int.Parse(columnO), PlayerEnum.O, true); */


                        if (int.Parse(rowX) == 0 && int.Parse(columnX) == 0)
                        {
                            player1[0] = '0';
                        }
                        if (int.Parse(rowX) == 0 && int.Parse(columnX) == 1)
                        {
                            player1[1] = '0';
                        }
                        if (int.Parse(rowX) == 0 && int.Parse(columnX) == 2)
                        {
                            player1[2] = '0';
                        }
                        if (int.Parse(rowX) == 1 && int.Parse(columnX) == 0)
                        {
                            player1[3] = '0';
                        }
                        if (int.Parse(rowX) == 1 && int.Parse(columnX) == 1)
                        {
                            player1[4] = '0';
                        }
                        if (int.Parse(rowX) == 1 && int.Parse(columnX) == 2)
                        {
                            player1[5] = '0';
                        }
                        if (int.Parse(rowX) == 2 && int.Parse(columnX) == 0)
                        {
                            player1[6] = '0';
                        }
                        if (int.Parse(rowX) == 2 && int.Parse(columnX) == 1)
                        {
                            player1[7] = '0';
                        }
                        if (int.Parse(rowX) == 2 && int.Parse(columnX) == 2)
                        {
                            player1[8] = '0';
                        }
                    }
                    if (index == 0 || index % 2 == 0) ;
                    {


                        Console.SetCursorPosition(40, 18);
                        Console.Write("Player 2");

                        Console.SetCursorPosition(40, 20);
                        Console.Write("Please enter Row:");
                        var rowO = Console.ReadLine();

                        Console.SetCursorPosition(40, 21);
                        Console.Write("Please Enter Column: ");
                        var columnO = Console.ReadLine();

                        _boardRenderer.AddMove(int.Parse(rowO), int.Parse(columnO), PlayerEnum.O, true);


                            if (int.Parse(rowO) == 0 && int.Parse(columnO) == 0)
                            {
                                player1[0] = '0';
                            }
                            if (int.Parse(rowO) == 0 && int.Parse(columnO) == 1)
                            {
                                player1[1] = '0';
                            }
                            if (int.Parse(rowO) == 0 && int.Parse(columnO) == 2)
                            {
                                player1[2] = '0';
                            }
                            if (int.Parse(rowO) == 1 && int.Parse(columnO) == 0)
                            {
                                player1[3] = '0';
                            }
                            if (int.Parse(rowO) == 1 && int.Parse(columnO) == 1)
                            {
                                player1[4] = '0';
                            }
                            if (int.Parse(rowO) == 1 && int.Parse(columnO) == 2)
                            {
                                player1[5] = '0';
                            }
                            if (int.Parse(rowO) == 2 && int.Parse(columnO) == 0)
                            {
                                player1[6] = '0';
                            }
                            if (int.Parse(rowO) == 2 && int.Parse(columnO) == 1)
                            {
                                player1[7] = '0';
                            }
                            if (int.Parse(rowO) == 2 && int.Parse(columnO) == 2)
                            {
                                player1[8] = '0';
                            }

                    

                        }

                    }
                }
            }
        }
    

