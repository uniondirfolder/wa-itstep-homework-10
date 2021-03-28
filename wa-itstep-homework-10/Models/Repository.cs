using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa_itstep_homework_10.Models
{
    public class Repository
    {
        private static readonly IList<Participant> participants = new List<Participant>();

        public static IEnumerable<Participant> Participants => participants;

        public static void AddParticipant(Participant participant) => participants.Add(participant);
    }
}
