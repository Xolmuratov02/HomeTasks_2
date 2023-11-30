using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using N75.Models.Common;
using N75.Models.Entities;
using N75.Models.Enums;

namespace N75.EntityConfigurations;

public class NotificationEventConfiguration : IEntityTypeConfiguration<NotificationEvent>
{
    public void Configure(EntityTypeBuilder<NotificationEvent> builder)
    {
        builder
            .ToTable("NotificationEvents")
            .HasDiscriminator(notificationEvent => notificationEvent.Type)
            .HasValue<EmailNotificationEvent>(NotificationType.Email);
    }
}