namespace TasteFoodIt.Entities;

public class Notification
{
    public int NotificationId { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public bool IsRead { get; set; }
    public string NotificationIcon { get; set; }
    public string?  IconCircleColor { get; set; }
}