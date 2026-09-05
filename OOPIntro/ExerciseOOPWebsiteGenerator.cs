namespace OOPIntro;

// Recreate the HTML website generator to an OOP app.
    // Firstly, make sure you have a git repo containing at least one commit showing the project in its current form.
// Create a class along the lines of WebsiteGenerator.
// Let the class contain the methods you created earlier.
// Create an instance of the website generator in the Main-method.
// Call the appropriate methods to generate the HTML and show it in the console.
// 
public class ExerciseOOPWebsiteGenerator
{
    private string DefaultName(string klassNamn="klassen")
    {
        return klassNamn;
    }
    private string[] DefaultMessage(string[] meddelanden, int antalMeddelanden)
    {
        // Om användaren anger färre meddelanden än vad som efterfrågas.
        if (meddelanden.Length < antalMeddelanden)
        {
            //Kopiera användarens möjliga angivna värden (som finns i meddelanden arrayen) till en större array
            string[] störreArray = new String[antalMeddelanden];
            meddelanden.CopyTo(störreArray, 0);
            
            for (int i = 0; i < antalMeddelanden; i++)
            {
                // Om värdet på index i är tomt (null), tilldela default värde "Mer info tillkommer" 
                störreArray[i] ??= "Mer info tillkommer";
            }
            // Returnera den större arrayen.
            return störreArray;
        }

        return meddelanden;
    }
    public string GenerateHTMLTemplate(string klassNamn, string[] klassMeddelanden)
    {
        string[] korrMeddelanden = DefaultMessage(klassMeddelanden,3);
        string htmlOutput =
            @$"<!DOCTYPE html>
<html>
<body>
    <h1>Välkomna {DefaultName(klassNamn)}!</h1>
    <p><b>Meddelande 1:</b> {korrMeddelanden[0]}.</p>
    <p><b>Meddelande 2:</b> {korrMeddelanden[1]}.</p>
    <p><b>Meddelande 3:</b> {korrMeddelanden[2]}.</p>
    <main>
        <p>Kurs om C#</p>
        <p>Kurs om Databaser</p>
    </main>
</body>
</html>";
        return htmlOutput;
    }
}