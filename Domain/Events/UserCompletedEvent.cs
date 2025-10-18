using Domain.Common.Base;
using Domain.Entities;

namespace Domain.Events;

public class UserCompletedEvent : BaseEvent
{
    public UserCompletedEvent(User user)
    {
        User = user;
    }

    public User User { get; }
}
