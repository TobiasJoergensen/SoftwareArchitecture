using AutoMapper;
using Domain.Entities;

namespace Application.Queries;

public class UserBriefDto
{
    public int UserID { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, UserBriefDto>();
            CreateMap<UserBriefDto, User>();
        }
    }
}
