﻿using HealthAndDrive.Models;
using Prism.Events;

namespace HealthAndDrive.Events.Notifications
{
    public class PushNotificationAlertEvent : PubSubEvent<NotificationMeasure>
    {
    }
}
