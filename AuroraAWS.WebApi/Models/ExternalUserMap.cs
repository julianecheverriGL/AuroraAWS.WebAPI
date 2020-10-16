using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AuroraAWS.WebApi.Enum;

namespace AuroraAWS.WebApi.Models
{
    [Table("ExternalUsersMap")]
    public class ExternalUserMap
    {
        [Key, Column("ExternalUserMapId")]
        public int Id { get; set; }

        public int ExternalUserId { get; set; }

        public EExternalUserType ExternalUserType { get; set; }
    }
}
