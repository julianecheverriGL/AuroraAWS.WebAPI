using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuroraAWS.WebApi.Models
{
    [Table("ExternalUsersApplicationMap")]
    public class ExternalUserApplicationMap
    {
        [Key, Column("ExternalUserApplicationMapId")]
        public int Id { get; set; }
        public int ExternalUserMapId { get; set; }
        public int ApplicationId { get; set; }
        public string MetaData { get; set; }

        public virtual ExternalUserMap ExternalUserMap { get; set; }
        public virtual Application Application { get; set; }
    }
}
