
using System.Threading.Channels;
using krokodilleOppgave;

Console.WriteLine("Oppgave: Krokodillespillet");
 /* OPPGAVE:
    Bruk det du har lært til å programmere “krokodille spillet”.
    
    For hver runde skal det printes ut til skjermen et random tall mellom 1-11, 
    et mellomrom og et nytt tall mellom 1-11,
    med en underscore mellom slik at det ser sånn ut: 3 _ 5
    
    Brukeren kan skrive inn <, > eller =
    (så hvis brukeren får 3 _ 5 vil svaret være <, altså 3 < 5)
    
    Tallene må sjekkes om det første er større eller mindre eller 
    lik det andre tallet,

    Det må verifiseres om brukeren har valgt riktig alternativ.

    Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.

    Poengsummen printes til skjermen for hvert svar brukeren har gitt.

    Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene.
  */

Console.WriteLine("Two random numbers will be printed. Which number is bigger? Or maybe they are equal?");
Console.WriteLine("Use < , > or = ");
Console.WriteLine();
Console.WriteLine("If you enter any other symbol than these three, the game ends.");
Console.WriteLine();
Console.WriteLine("Right answer gives you a point, wrong answer removes a point from your score.");
Console.WriteLine("Good luck!");
Console.WriteLine();

Thread.Sleep(2000);
Console.WriteLine();

var Krokodille = new Krokodille();
Krokodille.Run();