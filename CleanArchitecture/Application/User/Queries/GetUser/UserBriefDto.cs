using Domain.Entities;
using System;

namespace Application.Queries;

public class UserBriefDto
{
    public int? UserID { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public static UserBriefDto ToPersonDTOMap(User? user)
    {
        return new UserBriefDto()
        {
            UserID = user?.UserID,
            FirstName = user?.FirstName,
            LastName = user?.LastName
        };
    }
}
