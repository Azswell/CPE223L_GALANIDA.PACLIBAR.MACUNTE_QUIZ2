using Microsoft.AspNetCore.Identity;

namespace EquipmentTracker.Domain
{
    public class Equipment 
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int SerialNumber { get; set; }
        public Category Category { get; set; }  // prefer enum typed property
    }
}
