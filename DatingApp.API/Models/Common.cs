using System;

namespace DatingApp.API.Models
{
    public class Common
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public bool IsDeleted { get; set; } = false;
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}