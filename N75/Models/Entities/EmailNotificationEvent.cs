﻿using N75.Models.Common;

namespace N75.Models.Entities;

public class EmailNotificationEvent : NotificationEvent
{
    public string Subject { get; set; } = default!;

    public string ReceiverEmailAddress { get; set; } = default!;
}