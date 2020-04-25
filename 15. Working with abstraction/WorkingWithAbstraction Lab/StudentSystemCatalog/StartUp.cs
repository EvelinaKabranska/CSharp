namespace StudentSystemCatalog
{
    using System;
    using Comands;
    using Students;
    public class StartUp
    {
        public static void Main()
        {
            var comandParser = new CommandParser();
            var studentSystem = new StudentSystem();
            var engine = new Engine(comandParser, studentSystem,Console.ReadLine);
            engine.Run();
        }
    }
}
