using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand:IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
