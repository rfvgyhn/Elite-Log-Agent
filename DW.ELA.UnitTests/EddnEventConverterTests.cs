﻿using DW.ELA.Interfaces;
using DW.ELA.Interfaces.Events;
using DW.ELA.Plugin.EDDN;
using DW.ELA.Plugin.EDDN.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW.ELA.UnitTests
{
    [TestFixture]
    public class EddnEventConverterTests
    {
        private readonly EddnEventConverter eventConverter = new EddnEventConverter();

        [Test]
        [TestCaseSource(typeof(TestEventSource), nameof(TestEventSource.LogEvents))]
        public void ShouldNotFailOnEvents(LogEvent e)
        {
            var result = eventConverter.Convert(e).ToList();
            Assert.NotNull(result);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(EddnEvent));
            var validator = new EventSchemaValidator();
            foreach (var @event in result)
                Assert.IsTrue(validator.ValidateSchema(@event), "Event {0} should have validated", e.Event);
        }
    }
}