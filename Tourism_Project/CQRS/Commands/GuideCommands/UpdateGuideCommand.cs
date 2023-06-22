using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.CQRS.Commands.GuideCommands
{
    public class UpdateGuideCommand:IRequest
    {
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
