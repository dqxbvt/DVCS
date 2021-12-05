using System;

namespace ConsoleAppTictac
{

    class Program
    {

        static void Main()
        {

            char player = 'X';

            char[,] board = new char[3, 3];

            bool playAgain = true;

            int moovesPlayed = 0;


            while (playAgain == true)
            {

                Console.Clear();

                DrawBoard(board);

                Console.WriteLine("\n");


                int row, col;

            
                addData(out row, out col);

              

                if (board[row, col] == 'X' || board[row, col] == 'X')
                {

                    Console.WriteLine("Already exist");

                    Console.ReadKey();

                }

                else
                {

                    board[row, col] = player;

                    moovesPlayed++;

                }



                //Check if player won 


                

                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2]

                    || player == board[1, 0] && player == board[1, 1] && player == board[1, 2]

                    || player == board[2, 0] && player == board[2, 1] && player == board[2, 2]



                  

                    || player == board[0, 0] && player == board[1, 0] && player == board[2, 0]

                    || player == board[0, 1] && player == board[1, 1] && player == board[2, 1]

                    || player == board[0, 2] && player == board[1, 2] && player == board[2, 2]


                    || player == board[0, 0] && player == board[1, 1] && player == board[2, 2]
                    || player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                {



                    Console.WriteLine($" {player} has won");

                    Console.WriteLine("Play again? N" + "/" + "Y");

                    string input = Console.ReadLine();



                    if (input.ToLower() == "y")
                    {

                        playAgain = true;

                        Main();



                    }

                    else if (input.ToLower() == "n")
                    {

                        playAgain = false;

                    }

                }



                if (moovesPlayed == 9)
                {



                    Console.WriteLine("Is a Draw");

                    break;

                }


           

                player = ChangeTurn(player);



                DrawBoard(board);



            }



        }

        //Functions used 
        private static void addData(out int row, out int col)
        {


            Console.Write("Enter row: ");



            string inputRow = Console.ReadLine();

            while (!int.TryParse(inputRow, out row))
            {


                Console.Write("Enter row: ");

                inputRow = Console.ReadLine();

            }

            Console.Write("Enter column: ");

            string inputColunm = Console.ReadLine();

            while (!int.TryParse(inputColunm, out col))
            {


                Console.Write("Enter column: ");

                inputColunm = Console.ReadLine();

            }

        }


        private static char ChangeTurn(char currentPlayer)
        {



            if (currentPlayer == 'X')
            {

                return 'O';

            }

            else
            {

                return 'X';

            }

        }


        private static void DrawBoard(char[,] board)
        {


            Console.Write("     0   1   2  ");

            Console.WriteLine("\n");


            for (int row = 0; row < 3; row++)
            {


                Console.Write($"{row}  | ");

                for (int colnum = 0; colnum < 3; colnum++)
                {


                    Console.Write(board[row, colnum]);

                    Console.Write(" | ");

                }

                Console.WriteLine();

            }

        }

    }

}