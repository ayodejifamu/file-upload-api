using System;
using System.ComponentModel.DataAnnotations;

namespace fileUploadApi.SharedKernel
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string fileUniqueId { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
        public string? userUniqueId { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}