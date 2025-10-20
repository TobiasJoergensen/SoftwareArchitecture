
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;
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
    private readonly IMapper _mapper;

    public GetUserQueryHandler(IApplicationDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserBriefDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var test = _context.Users
            .Where(x => x.UserID == 0);
        UserBriefDto ubdto = new UserBriefDto()
        {
            UserID = test.First().UserID,
            FirstName = test.First().FirstName,
            LastName = test.First().LastName,
        };

        return ubdto;
    }
}
