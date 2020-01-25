using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class LeverTests
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestCountIs60OnStart()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            LeverBehaviour lever = new LeverBehaviour();
            
            Assert.AreEqual(lever.count, 60);
            yield return null;
        }
    }
}
