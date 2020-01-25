using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PauseMenuTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestPauseIsFalseOnStart()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            PauseMenu pause = new PauseMenu();

            Assert.AreEqual(pause.GameIsPaused, false);

            yield return null;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestPause()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            PauseMenu pause = new PauseMenu();

            pause.TestPause();

            Assert.AreEqual(Time.timeScale, 0.0f);
            Assert.AreEqual(pause.GameIsPaused, true);

            yield return null;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestTimeAfterResume()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            PauseMenu pause = new PauseMenu();

            pause.TestResume();

            Assert.AreEqual(Time.timeScale, 1.0f);
            Assert.AreEqual(pause.GameIsPaused, false);
            yield return null;
        }
    }
}
