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
    private string[] board =
    [
        "|' '|", "|' '|", "|' '|",
        "|' '|", "|' '|", "|' '|",
        "|' '|", "|' '|", "|' '|"
    ];

    private string[] players = ["X", "O"];
    private int currentPlayer = 0;
    private int placeCounter = 0;


    public void Game()
    {
        bool gameOver = false;
        ShowBoard();
        while (!gameOver)
        {
            // board[Placement()-1] = $"|'{players[currentPlayer]}'|";
            ShowBoard();
            placeCounter--;
            if (placeCounter == 0) gameOver = true;
            SwitchPlayer();
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

        Console.WriteLine(rows);
    }

    private void PlaceMark()
    {
        int number = Int32.Parse(Console.ReadKey().KeyChar.ToString());
    }

    private void SwitchPlayer()
    {
        switch (currentPlayer)
        {
            case 0:
                currentPlayer = 1;
                break;
            case 1:
                currentPlayer = 0;
                break;
        }
    }
}