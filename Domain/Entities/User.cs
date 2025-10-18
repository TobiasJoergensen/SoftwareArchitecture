using Domain.Common.Base;
using Domain.Events;

namespace Domain.Entities;

public class User : BaseAuditableEntity
{
    public int UserID { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }


    private bool _done;
    public bool Done
    {
        get => _done;
        set
        {
            if (value && !_done)
            {
                AddDomainEvent(new UserCompletedEvent(this));
            }

            _done = value;
        }
    }

    public UserList List { get; set; } = null!;
}
