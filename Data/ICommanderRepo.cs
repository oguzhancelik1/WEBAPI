using System.Collections.Generic;
using ProjectCommander.Models;

namespace ProjectCommander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }



}