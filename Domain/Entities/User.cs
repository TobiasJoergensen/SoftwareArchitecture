using Domain.Common.Base;
using Domain.Events;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class User : BaseAuditableEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Column("UserID")]
    public int UserID { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
