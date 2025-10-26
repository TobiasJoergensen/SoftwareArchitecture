using Domain.Common.Base;
using Domain.Entities;

namespace Domain.Events;

public class UserItemDeletedEvent : BaseEvent
{
    public UserItemDeletedEvent(User user)
    {
        User = user;
    }

    public User User { get; }
}
