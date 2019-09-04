using System;
using System.Collections.Generic;

namespace AgendaCompromissos.Models
{
    public class Commitments
    {
        public int Id { get; set; }

        public DateTime Begin { get; set; }

        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public String subject_matter { get; set; }

        public Commitments()
        {

        }

        public Commitments(int id, DateTime begin, string subject_matter)
        {
            Id = id;
            Begin = begin;
            this.subject_matter = subject_matter;
        }


    }
}
