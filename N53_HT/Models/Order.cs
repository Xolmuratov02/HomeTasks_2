﻿namespace N53_HT.Models;

public class Order : Auditable
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}