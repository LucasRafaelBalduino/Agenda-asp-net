using System;

namespace AgendaCompromissos.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String surname { get; set; }
        public int Fone { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Contact()
        {

        }

        public Contact(int id, string name, string surname, int fone, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            this.surname = surname;
            Fone = fone;
            Email = email;
            BirthDate = birthDate;
        }

    }
}
