using Application.Interfaces;
using Domain.Entities;
using Domain.Events;
using MediatR;

namespace Application.Commands.CreateTodoItem;

public record CreateUserCommand : IRequest<int>
{
    public int UserID { get; init; }

    public string? FirstName { get; init; }
    public string? LastName { get; init; }

}

public class CreateTodoItemCommandHandler : IRequestHandler<CreateUserCommand, int>
{
    private readonly IApplicationDBContext _context;

    public CreateTodoItemCommandHandler(IApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var entity = new User
        {
            UserID = request.UserID,
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        entity.AddDomainEvent(new UserCreatedEvent(entity));

        _context.Users.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.UserID;
    }
}
