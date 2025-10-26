
using Application.Interfaces;
using MediatR;

namespace Application.Queries;

public record GetUserQuery : IRequest<UserBriefDto>
{
    public int UserId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
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
        var test = _context.Users
            .Where(x => x.UserID == 0);

        return UserBriefDto.ToPersonDTOMap(test.First());
    }
}
