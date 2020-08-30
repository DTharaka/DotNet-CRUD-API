using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{ Id = 1, HowTo = "Study in uni", Line = "Pass exam", Platform = "Education"},
                new Command{ Id = 2, HowTo = "Prepare a meal", Line = "Make curries", Platform = "Cooking"},
                new Command{ Id = 3, HowTo = "Play cricket", Line = "Practice well", Platform = "Playing"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{ Id = 1, HowTo = "Study in uni", Line = "Pass exam", Platform = "Education"};
        }
    }
}