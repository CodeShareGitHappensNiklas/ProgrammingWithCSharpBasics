namespace OOPIntro;

// Steps

// Step 1:
// Create a game where 2 people can play tic-tac-toe
// player1/player2 fill in their respective square by picking a number between 1-9.
// The numbers represent the squares on the grid.
// Present the playing field by iterating 'X'/'O'/' ' from an array.
// Keep the game going using a loop.
// When the game is over, display a message showing which player won (or if it was a tie).

// Step 2:
// Use methods to make your tic-tac-toe game cleaner and more readable.
// An important part of this exercise is to limit the mental strain for fellow programmers reading the code.
// This will also help with structuring new features.

// Step 3:
// Refactor the Tic-Tac-Toe game into an OOP application.

public class ExerciseOopTicTacToe
{
    private static string[] board =
    [
        "|' '|", "|' '|", "|' '|",
        "|' '|", "|' '|", "|' '|",
        "|' '|", "|' '|", "|' '|"
    ];

    private string[] PlayerMarks = ["|'X'|", "|'0'|"];
    private int CurrentPlayer = 0;
    private int PlaceCounter = board.Length;
    private bool GameOver = false;


    public void Game()
    {
        ShowBoard();

        while (!GameOver)
        {
            PlaceMark();
            ShowBoard();
            WinConditions();
            if (PlaceCounter == 0)
            {
                Console.WriteLine("\nIt's a Draw!");
                GameOver = true;
            }
        }
    }
    private void PlaceMark()
    {
        int index = Int32.Parse(Console.ReadKey().KeyChar.ToString()) - 1;
        if (board[index] == "|' '|")
        {
            board[index] = PlayerMarks[CurrentPlayer];
            PlaceCounter--;
            SwitchPlayer();
        }
        else
        {
            Console.WriteLine($"\n\nCan't place mark on square {index+1}.\n" +
                              $"Please pick another square.");
        }
    }
    private void ShowBoard()
    {
        string rows = "\n";
        int slotCounter = 0;
        foreach (string slot in board)
        {
            if (slotCounter == 3)
            {
                rows += "\n";
                slotCounter = 0;
            }

            rows += slot;
            slotCounter++;
        }

        Console.WriteLine($"\nPlayer {CurrentPlayer + 1}'s turn");
        Console.WriteLine(rows);
    }
    private void WinConditions()
    {
        /*TODO: Add a win condition when one of the rows, columns,
         or diagonals get three of the same characters in a row*/
        string[] rows =
        [
            board[0] + board[1] + board[2],
            board[3] + board[4] + board[5],
            board[6] + board[7] + board[8]
        ];
        string[] columns =
        [
            board[0] + board[3] + board[6],
            board[1] + board[4] + board[7],
            board[2] + board[5] + board[8]
        ];
        string[] diagonals =
        [
            board[0] + board[4] + board[8],
            board[2] + board[4] + board[6]
        ];
        for (int i = 0; i < rows.Length; i++)
        {
            rows[i] = CleanString(rows[i]);
            columns[i] = CleanString(columns[i]);
            if (i < diagonals.Length)
            {
                diagonals[i] = CleanString(diagonals[i]);
            }
        }
        Console.WriteLine($"\nRow 1: {rows[0]}\nRow 2: {rows[1]}\nRow 3: {rows[2]}");
        Console.WriteLine($"\nCol 1: {columns[0]}\nCol 2: {columns[1]}\nCol 3: {columns[2]}");
        Console.WriteLine($"\nDiag 1: {diagonals[0]}\nDiag 2: {diagonals[1]}");
    }
    private string CleanString(string input)
    {
        return input.Replace("|", "").Replace("'", "");
    }
    private void SwitchPlayer()
    {
        switch (CurrentPlayer)
        {
            case 0:
                CurrentPlayer = 1;
                break;
            case 1:
                CurrentPlayer = 0;
                break;
        }
    }
}