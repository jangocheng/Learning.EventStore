﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using FakeItEasy;
using Learning.EventStore.Cache;
using Learning.EventStore.Domain;
using Learning.EventStore.Test.Mocks;
using NUnit.Framework;

namespace Learning.EventStore.Test
{
    public class CacheTest
    {
        private readonly IRepository _cacheRepository;
        private readonly MemoryCache _memoryCache;
        private readonly TestAggregate _aggregate;

        public CacheTest()
        {
            _memoryCache = new MemoryCache();
            IEventStore eventStore = new TestEventStore();
            _cacheRepository = new CacheRepository(new TestRepository(), eventStore, _memoryCache);
            _aggregate = _cacheRepository.Get<TestAggregate>(Guid.NewGuid()).Result;
        }

        
    }
}
