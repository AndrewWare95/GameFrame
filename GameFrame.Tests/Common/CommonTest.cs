﻿using GameFrame.Common;
using MonoGame.Extended;
using NUnit.Framework;
using MonoGame.Extended.ViewportAdapters;

namespace GameFrame.Tests.Common
{
    [TestFixture]
    public class CommonTest
    {
        [Test]
        public void TestCameraTracker()
        {
            Camera2D Camera2D = null;
            IFocusAble focusAble = null;
            var tracker = new CameraTracker(Camera2D, focusAble);
            Assert.IsNotNull(tracker);
        }

        [Test]
        public void TestCameraUpdate()
        {

        }
    }
}
