﻿namespace N74.Models;

public class User
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = default;

    public string LastName { get; set; } = default;
}
