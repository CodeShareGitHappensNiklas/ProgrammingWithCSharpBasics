namespace Main;
using OOPIntro;
class Program
{
    static void Main(string[] args)
    {
        ExerciseOopTicTacToe ticTacToe = new ExerciseOopTicTacToe();
        Console.ForegroundColor = ConsoleColor.Green;
        ticTacToe.Game();
        Console.ForegroundColor = ConsoleColor.White;
    }
}