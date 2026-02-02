
using Application.Interfaces;
using Domain.Entities;
using Domain.Events;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries;

public record DeleteUserCommand : IRequest<int>
{
    public int UserId { get; init; }

    public DeleteUserCommand(int userId) {  UserId = userId; }
}

public class DeleteUserQueryHandler : IRequestHandler<DeleteUserCommand, int>
{
    private readonly IApplicationDBContext _context;

    public DeleteUserQueryHandler(IApplicationDBContext context)
    {
        _context = context;
    }
     
    public async Task<int> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var entity = new User
        {
            UserID = request.UserId
        };

        entity.AddDomainEvent(new UserDeletedEvent(entity.UserID));

        _context.Users.Where(user => user.UserID == entity.UserID).ExecuteDelete();

        await _context.SaveChangesAsync(cancellationToken);

        return entity.UserID;
    }
}
