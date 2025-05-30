using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using UCK.Api.Models.attendees;

namespace UCK.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<attendee> attendees { get; set; }

        public async ValueTask<attendee> InsertattendeeAsync(attendee attendee)
        {
            using var broker =
                new StorageBroker(this.configuration);

            EntityEntry<attendee> attendeeEntityEntry =
                await broker.attendees.AddAsync(attendee);

            await broker.SaveChangesAsync();

            return attendeeEntityEntry.Entity;
        }

        public IQueryable<attendee> SelectAllattendees()
        {
            using var broker =
                new StorageBroker(this.configuration);

            return broker.attendees;
        }

        public async ValueTask<attendee> SelectattendeeByIdAsync(Guid attendeeId)
        {
            using var broker =
                new StorageBroker(this.configuration);

            return await broker.attendees.FindAsync(attendeeId);
        }

        public async ValueTask<attendee> UpdateattendeeAsync(attendee attendee)
        {
            using var broker =
                new StorageBroker(this.configuration);

            EntityEntry<attendee> attendeeEntityEntry =
                broker.attendees.Update(attendee);

            await broker.SaveChangesAsync();

            return attendeeEntityEntry.Entity;
        }
    }
}
