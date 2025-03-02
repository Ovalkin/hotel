using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Common.EntityModel.PostgreSql.Entities;

[Table("payments")]
public class Payment
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("booking_id")]
    public int BookingId { get; set; }
    
    [ForeignKey("booking_id")]
    public Booking Booking { get; set; }
    
    [Column("user_id")]
    public int UserId { get; set; }
    
    [ForeignKey("user_id")]
    public User User { get; set; }
    
    [Column("amount")]
    public decimal Amount { get; set; }
    
    [Column("date")]
    public DateTime Date { get; set; }
    
    [Column("method")]
    [StringLength(255)]
    public string Method { get; set; }
    
    [Column("status")]
    [StringLength(255)]
    public string Status { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}