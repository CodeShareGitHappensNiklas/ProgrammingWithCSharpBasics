namespace Main;
using OOPIntro;
class Program
{
    
    static void Main(string[] args)
    {
        ExerciseOopWebsiteGenerator generator = new ExerciseOopWebsiteGenerator();
        string html = generator.GenerateHtmlTemplate();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(html);
        Console.ForegroundColor = ConsoleColor.White;
    }
}