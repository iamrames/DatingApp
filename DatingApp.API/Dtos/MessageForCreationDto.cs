using System;
namespace DatingApp.API.Dtos
{
    public class MessageForCreationDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime MessageSent { get; set; } = DateTime.Now;
        public string Content { get; set; }
    }
}