using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerTest
    {
        playerBehaviour player = new playerBehaviour();

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestPlayerActiveFalseOnStart()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            Assert.AreEqual(player.active, false);

            yield return null;
        }

        [UnityTest]
        public IEnumerator TestToggleActive()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.

            player.toggleActive();

            Assert.AreEqual(player.active, true);

            yield return null;
        }
    }
}
