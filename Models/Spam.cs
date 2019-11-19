using System;

namespace SpamAPI
{
    public class Spam
    {
        public int SpamId { get; set; }
        public string Spammer { get; set; }
        public string APIKey { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
