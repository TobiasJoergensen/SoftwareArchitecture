using Domain.Common.Base;
using Domain.Entities;

namespace Domain.Events;

public class UserDeletedEvent : BaseEvent
{
    public UserDeletedEvent(int UserID)
    {
        userID = UserID;
    }

    public int userID { get; }
}
