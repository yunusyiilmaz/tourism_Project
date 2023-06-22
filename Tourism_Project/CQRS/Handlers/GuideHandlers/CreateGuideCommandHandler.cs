using DataAccess.Concrete;
using Entity.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tourism_Project.CQRS.Commands.GuideCommands;

namespace Tourism_Project.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler:IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;
        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
