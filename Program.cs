//Erstelle einen einfachen Taschenrechner.
//Der User soll nacheinander zwei Zahlen und auch ein Zeichen für die Rechenart eingeben können.
//(+ - * /)
//Anschließend wird die Berechnung durchgeführt und das Ergebnis ausgegeben.
//Nach Ausgabe des Ergebnis frage den User, ob er eine weitere Berechnung durchführen möchte, oder ob er das Programm verlassen will.

double result = 0;
bool weiter = true;

while (weiter)
{
    Console.WriteLine("Erste Zahl:");
    double zahlEins = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Zweite Zahl:");
    double zahlZwei = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Rechenzeichen: +\t-\t*\t/");
    char rechnen = Convert.ToChar(Console.ReadLine());
    Console.WriteLine();
    switch (rechnen)
    {
        case '+':
            result = zahlEins + zahlZwei;
            break;
        case '-':
            result = zahlEins - zahlZwei;
            break;
        case '*':
            result = zahlEins * zahlZwei;
            break;
        case '/':
            if (zahlZwei != 0)
            {
                result = zahlEins / zahlZwei;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Man kann nicht durch Null teilen.");
                continue;
            }
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Ungültiges Rechenzeichen.");
            continue;
    }
    Console.WriteLine();
    Console.WriteLine("Das Ergebnis lautet: " + result);
    Console.WriteLine();
    Console.WriteLine("Möchtest du mit deinen Berechnungen fortfahren? (ja/nein):");
    string antwort = Console.ReadLine();
    Console.WriteLine();

    if (antwort.ToLower() != "ja")
    {
        weiter = false;
    }
}
Console.WriteLine();
Console.WriteLine("Programm beendet.");
Console.ReadKey();


//LÖSUNG FABIAN
double zahl1, zahl2;
double ergebnis = 0;
string rechenart;
bool wiederholung = false;

do
{
    bool operatorOk = true;
    Console.Clear();
    Console.WriteLine("Hallo User!\nBitte gib deine erste Zahl ein.");
    zahl1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Bitte gib nun die Art der Berechnung an.\nEs stehen  + - * / zur Verfügung.");
    rechenart = Console.ReadLine();
    Console.WriteLine("Bitte gib nun deine zweite Zahl ein.");
    zahl2 = Convert.ToDouble(Console.ReadLine());

    switch(rechenart)
    {
        case "+":
            ergebnis = zahl1 + zahl2;
            break;
            
        case "-":
            ergebnis = zahl1 - zahl2;
            break;

        case "*":
            ergebnis = zahl1 * zahl2;
            break;

        case "/":
            ergebnis = zahl1 / zahl2;
            break;
        default:
            Console.WriteLine("Ungültiger Operator.\nEs stehen nur + - * / zur Verfügung wie schon sagte...");
            operatorOk = false;
            break;
    }
    if(operatorOk)
    {
        Console.WriteLine($"{zahl1} {rechenart} {zahl2} = {ergebnis}");
    }
    Console.WriteLine("Möchtest du eine weitere Berechnung ausführen? j/n");
    string eingabe = Console.ReadLine().ToLower();
    wiederholung = eingabe == "j";
}
while(wiederholung);