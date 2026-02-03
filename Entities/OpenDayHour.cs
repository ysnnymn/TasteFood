using System.ComponentModel.DataAnnotations;

namespace TasteFoodIt.Entities;

public class OpenDayHour
{
    public int OpenDayHourId { get; set; }
    [StringLength(9)]
    [Required]
    public string DayName { get; set; }
    
    [StringLength(20)]
    public string OpenHourRange { get; set; }
    
}