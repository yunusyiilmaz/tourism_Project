using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourism_Project.CQRS.Commands.GuideCommands;

namespace Tourism_Project.CQRS.Handlers.GuideHandlers
{
    public class RemoveGuideCommandHandler
    {
        private readonly Context _context;
        public RemoveGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveGuideCommand command)
        {
            var values = _context.Guides.Find(command.Id);
            _context.Guides.Remove(values);
            _context.SaveChanges();
        }
    }
}
