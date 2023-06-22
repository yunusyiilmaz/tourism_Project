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
    public class UpdateGuideCommandHandler : IRequestHandler<UpdateGuideCommand>
    {
        private readonly Context _context;
        public UpdateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateGuideCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Guides.Find(request.GuideID);
            //_context.Guides.Update(new Guide
            //{
            //    Name = request.Name,
            //    Description = request.Description,
            //    Status = true
            //});
            values.Name = request.Name;
            values.Description = request.Description;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
