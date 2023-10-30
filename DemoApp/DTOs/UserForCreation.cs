﻿namespace DemoApp.DTOs;

public class UserForCreation
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public DateTime DateOfBirth { get; set; }
}