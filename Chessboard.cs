using System;

class Chessboard {
    public string[,] board;

    public Chessboard() {
        board = new string[8, 8];

        // linha 0
        board[0, 0] = "♜"; board[0, 1] = "♞"; board[0, 2] = "♝"; board[0, 3] = "♛";
        board[0, 4] = "♚"; board[0, 5] = "♝"; board[0, 6] = "♞"; board[0, 7] = "♜";

        // linha 1
        for (int j = 0; j < 8; j++) board[1, j] = "♟";

        // linha 6
        for (int j = 0; j < 8; j++) board[6, j] = "♙";

        // linha 7
        board[7, 0] = "♖"; board[7, 1] = "♘"; board[7, 2] = "♗"; board[7, 3] = "♕";
        board[7, 4] = "♔"; board[7, 5] = "♗"; board[7, 6] = "♘"; board[7, 7] = "♖";

        // linhas 2-5
        for (int i = 2; i < 6; i++) {
            for (int j = 0; j < 8; j++) {
                board[i, j] = " ";
            }
        }
    }
}