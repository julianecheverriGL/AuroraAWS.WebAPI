using System;
using AuroraAWS.WebApi.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuroraAWS.WebApi.Models
{
    [Table("Applications")]
    public class Application
    {
        [Key, Column("ApplicationId")]
        public int Id { get; set; }
        public EApplicationCode ApplicationCode { get; set; }
    }
}
