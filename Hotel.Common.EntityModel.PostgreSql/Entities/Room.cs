using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hotel.Common.EntityModel.PostgreSql.Enums;

namespace Hotel.Common.EntityModel.PostgreSql.Entities;

[Table("rooms")]
public class Room
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("number")]
    public int Number { get; set; }
    
    [Column("type")]
    [StringLength(255)]
    public string Type { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("status")]
    public RoomStatusEnum Status { get; set; }
    
    [Column("price")]
    public decimal Price { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}