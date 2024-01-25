/*
  Exempel 3. Skriv en konsolapplikation för att skapa följande klasser:
•	DrawObject som innehåller en virtuell metod Draw() som skriver ut texten ”Jag är bas ritobjekt.",
•	Klass Line som ärver klassen DrawObject och har metoden Draw()
•	Circle som ärver DrawObject-klassen och har en Draw()-metod,
•	Kvadrat som ärver klassen DrawObject och har metoden Draw()
•	DemoForDrawing, där Main - funktionen definieras med skapade objekt för ritning
  */

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoForDrawing demoForDrawing = new DemoForDrawing();
            demoForDrawing.MainMeny();
        }
    }
}
