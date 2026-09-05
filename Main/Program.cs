namespace Main;
using OOPIntro;
class Program
{
    
    static void Main(string[] args)
    {
        ExerciseOOPWebsiteGenerator htmlGenerator = new ExerciseOOPWebsiteGenerator();
        
        string html = htmlGenerator.GenerateHTMLTemplate("Klass 26",[]);
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(html);
        Console.ForegroundColor = ConsoleColor.White;
    }
}