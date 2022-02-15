using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET6JWT.Data.Models;
public class RefreshToken
{
    [Key]
    public int Id { get; set; }

    public string Token { get; set; }

    public string Jwt { get; set; }

    public bool IsRevoked { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime DateExpire { get; set; }

    public string UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public ApplicationUser User { get; set; }
}