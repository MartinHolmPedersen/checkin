using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace scrum_checkin.Model
{
    public class CheckinSessionsDbContext : DbContext
    {
        public CheckinSessionsDbContext(DbContextOptions<CheckinSessionsDbContext> options) : base(options)
        {
        }
        public DbSet<CheckInSession> Sessions { get; set; }
        public DbSet<Participant> Participants { get; set; }

    }
    public class CheckInSession
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public DateTime SessionTime { get; set; }
        public List<Participant> Participants { get; set; }
    }
    public class Participant
    {
        public int Id { get; set; }
        public string TeamMemberName { get; set; }
        public int Score { get; set; }
    }
}
