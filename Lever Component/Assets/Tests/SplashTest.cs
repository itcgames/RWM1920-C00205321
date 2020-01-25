using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SplashTest
    {

        SplashScript splash = new SplashScript();

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestTimeLimitIs0()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            Assert.AreEqual(splash.timeLimit, 0);            
            yield return null;
        }

        [UnityTest]
        public IEnumerator TestTimerStartsAt6()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            Assert.AreEqual(splash.timer, 6);
            yield return null;
        }
    }
}
