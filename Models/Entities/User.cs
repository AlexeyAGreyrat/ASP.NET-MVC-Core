using System;

namespace Lesson9.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public DateTime? EmailConfirmDate { get; set; }

        public bool AcceptEmailConversation { get; set; }
        
        public DateTime RegisterDate { get; set; }

    }
}