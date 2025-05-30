using System;
using System.Linq;
using System.Threading.Tasks;
using UCK.Api.Models.attendees;

namespace UCK.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<attendee> InsertattendeeAsync(attendee attendee);
        IQueryable<attendee> SelectAllattendees();
        ValueTask<attendee> SelectattendeeByIdAsync(Guid attendeeId);
    }
}
