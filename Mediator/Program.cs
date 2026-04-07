namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ICommandCentre commandCentre = new CommandCentre();

            Runway runway1 = new Runway(commandCentre);
            Runway runway2 = new Runway(commandCentre);

            Aircraft boeing = new Aircraft("Boeing-737", commandCentre);
            Aircraft airbus = new Aircraft("Airbus-A320", commandCentre);
            Aircraft mriya = new Aircraft("An-225 Mriya", commandCentre);

            boeing.Land();
            Console.WriteLine();

            airbus.Land();
            Console.WriteLine();

            mriya.Land();
            Console.WriteLine();

            boeing.TakeOff();
            Console.WriteLine();

            mriya.Land();
        }
    }
}
