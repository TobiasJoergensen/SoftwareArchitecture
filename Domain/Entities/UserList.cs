using Domain.Common.Base;

namespace Domain.Entities;

public class UserList : BaseAuditableEntity
{
    public string? Title { get; set; }

    public IList<User> Items { get; private set; } = new List<User>();
}
