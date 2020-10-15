using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuroraAWS.WebApi.Models
{
     [Table("AssociationsPersons")]
    public class AssociationPerson
    {
         [Key]
        public int Id { get; set; }

        public int PersonId { get; set; }
        public int AssociationId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Association Association { get; set; }
    }
}

