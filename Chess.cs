using System;

class Chess {
    // csc Chess.cs Chessboard.cs
    static void Main() {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Chessboard chessboard = new Chessboard();
        string[,] board = chessboard.board;

        Console.WriteLine("  a b c d e f g h");
        Console.WriteLine("  ----------------");

        for (int i = 0; i < 8; i++) {
            Console.Write((8 - i) + "|");
            for (int j = 0; j < 8; j++) {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine("|" + (8 - i));
        }

        Console.WriteLine("  ----------------");
        Console.WriteLine("  a b c d e f g h");
    }
}