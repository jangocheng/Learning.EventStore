﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.EventStore.Sample.Web.Models.Events
{
    public class InventoryItemCreated : IEvent
    {
        public string Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public int Version { get; set; }
        public string AggregateType { get; set; }
        public string Name { get; set; }
    }
}
