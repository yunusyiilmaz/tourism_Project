using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.CQRS.Commands.GuideCommands
{
    public class RemoveGuideCommand
    {
        public RemoveGuideCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
