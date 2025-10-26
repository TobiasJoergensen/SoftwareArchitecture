using Domain.Common.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class UserList : BaseAuditableEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Column("UserID")]
    public int UserID { get; set; }
}
