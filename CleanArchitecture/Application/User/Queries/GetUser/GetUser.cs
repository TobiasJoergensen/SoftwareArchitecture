
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Queries;

public record GetUserQuery : IRequest<UserBriefDto>
{
    public int UserId { get; init; }
}

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserBriefDto>
{
    private readonly IApplicationDBContext _context;

    public GetUserQueryHandler(IApplicationDBContext context)
    {
        _context = context;
    }
     
    public async Task<UserBriefDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        User user = _context.Users
            .FirstOrDefault(x => x.UserID == request.UserId);

        return UserBriefDto.ToPersonDTOMap(user);
    }
}
