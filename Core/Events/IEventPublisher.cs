﻿using System;
namespace Core.Events
{
    public partial interface IEventPublisher
    {
        /// <summary>
        /// Publish event to consumers
        /// </summary>
        /// <typeparam name="TEvent">Type of event</typeparam>
        /// <param name="event">Event object</param>
        Task PublishAsync<TEvent>(TEvent @event);
    }
}