namespace N53_HT.Models;

public class Bonus : Auditable
{
    public Guid UserId { get; set; }
    public decimal Amount { get; set; }
}