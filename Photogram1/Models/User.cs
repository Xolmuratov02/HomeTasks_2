﻿namespace Photogram1.Models;

public class User : IEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfileImagePath { get; set; }
}