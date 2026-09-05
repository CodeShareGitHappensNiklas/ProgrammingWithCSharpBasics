namespace OOPIntro;

// Recreate the HTML website generator to an OOP app.
    // Firstly, make sure you have a git repo containing at least one commit showing the project in its current form.
// Create a class along the lines of WebsiteGenerator.
    // Let the class contain the methods you created earlier.
    // Create an instance of the website generator in the Main-method.
    // Call the appropriate methods to generate the HTML and show it in the console.
// Do you see any parts that can be refactored into fields/properties?
    // Split the class into fields (containing data with default values) and methods.

public class ExerciseOopWebsiteGenerator
{
    public string ClassName= "class";
    public string ClassDefaultMessage = "More info to come";
    public string[] Messages = new string[1];
    public string GenerateHtmlTemplate()
    {
        string htmlOutput = 
            @$"<!DOCTYPE html>
<html>
<body>
    <h1>Welcome {ClassName}!</h1>
    {MessageParagraph()}
    <main>
        <p><b>Course:</b> C#.</p>
        <p><b>Course:</b> Databases.</p>
    </main>
</body>
</html>";
        return htmlOutput;
    }
    private string MessageParagraph()
    {
        string message = "";
        for (int i = 0; i < Messages.Length; i++)
        {
            message += $"<p><b>Message {i+1}:</b> {Messages[i] ??= ClassDefaultMessage}.</p>";
            if (i < Messages.Length - 1)
            {
                message += "\n    ";
            }
        }
        return message;
    }
    
}
