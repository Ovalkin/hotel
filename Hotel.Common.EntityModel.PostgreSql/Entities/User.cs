using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hotel.Common.EntityModel.PostgreSql.Enums;

namespace Hotel.Common.EntityModel.PostgreSql.Entities;

[Table("users")]
public sealed class User
{
    [Key] 
    [Column("id")]
    public int Id { get; set; }
    
    [Column("role")]
    public RoleEnum Role { get; set; }

    [Column("first_name")] 
    [StringLength(255)]
    public string FirstName { get; set; } = null!;
    
    [Column("last_name")]
    [StringLength(255)]
    public string LastName { get; set; } = null!;
    
    [Column("sur_name")]
    [StringLength(255)]
    public string? SurName { get; set; }
    
    [Column("phone_number")]
    [StringLength(12)]
    public string PhoneNumber { get; set; } = null!;
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}