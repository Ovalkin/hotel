using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Common.EntityModel.PostgreSql.Entities;

[Table("bookings")]
public class Booking
{
    [Key] 
    [Column("id")]
    public int Id { get; set; }
    
    [Column("user_id")]
    public int UserId { get; set; }
    
    [ForeignKey("user_id")]
    public User User { get; set; }
    
    [Column("room_id")]
    public int RoomId { get; set; }
    
    [ForeignKey("room_id")]
    public Room Room { get; set; }
    
    [Column("check_ind_date")]
    public DateTime CheckInDate { get; set; }
    
    [Column("check_out_date")]
    public DateTime CheckOutDate { get; set; }
    
    [Column("total_cost")]
    public decimal TotalCost { get; set; }
    
    [Column("booking_status")]
    public bool BookingStatus { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}