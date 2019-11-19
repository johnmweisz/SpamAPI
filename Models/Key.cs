using System;

namespace SpamAPI
{
    public class Key
    {
        public int KeyId { get; set; }
        public string Email { get; set; }
        public string APIKey { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
