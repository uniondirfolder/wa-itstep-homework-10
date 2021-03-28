using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa_itstep_homework_10.Models
{
    public class Repository : DbContext
    {
        //private static readonly IList<Participant> participants = new List<Participant>();

        //public static IEnumerable<Participant> Participants => participants;

        //public static void AddParticipant(Participant participant) => participants.Add(participant);

        public DbSet<Participant> Participants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=.;Database=CRhw10;Trusted_Connection=True;");
    }
}
