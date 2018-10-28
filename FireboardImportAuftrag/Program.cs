using System;

namespace FireboardImportAuftrag
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                if (!int.TryParse(args[2], out var millisecondsBetweenAlarms))
                    millisecondsBetweenAlarms = 10000;

                var filename = args[0];
                var authKey = args[1];

                if (string.IsNullOrEmpty(args[0]) || string.IsNullOrEmpty(args[2]))
                {
                    PrintHelp();
                    return;
                }

                Console.WriteLine($"Importiere Alarme aus {filename}, verwende dazu authKey {authKey}. Wartezeit zwischen zwei Alarmen: {millisecondsBetweenAlarms}.");
                Console.WriteLine("Drücke eine Taste zum Start.");
                Console.ReadKey();

                var alarmHandler = new AlarmHandler();
                alarmHandler.ImportAlarms(authKey, filename, millisecondsBetweenAlarms);
            }
            catch (Exception e)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten:");
                Console.WriteLine(e);
                PrintHelp();
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Fireboard Import Aufträge");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Argumente: csvDatei fireboardAuthKey WartezeitInMillisekunden");
            Console.WriteLine("Beispiel:  alarme.csv 8RW..qyiA9N 10000");
        }
    }
}