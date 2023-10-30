﻿namespace N64.Identity.Application.Common.Notifications.Services;

public interface IEmailOrchestrationService
{
    ValueTask<bool> SendAsync(string emailAddress, string message);
}