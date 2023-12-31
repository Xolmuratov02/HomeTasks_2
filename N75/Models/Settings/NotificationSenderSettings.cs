﻿namespace N75.Models.Settings;

public class NotificationSenderSettings
{
    public int ResendAttemptsThreshold { get; set; }

    public int ResendIntervalInSeconds { get; set; }

    public int BatchSize { get; set; }

    public int BatchResentIntervalInSeconds { get; set; }
}