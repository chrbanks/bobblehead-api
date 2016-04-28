namespace BobbleheadApi.Models
{
    using System;
    
    public class Bobblehead
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime Timestamp { get; set; }
    }
}