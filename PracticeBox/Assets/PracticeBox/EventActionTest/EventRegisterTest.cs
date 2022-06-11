using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventActionTest {
    /// <summary>Debug.Logする</summary>
    public class EventRegisterTest : MonoBehaviour {
        [SerializeField] TestEvent testEvent;

        private void Start() {
            testEvent.action += SomeFunc;
            testEvent.action += SomeFunc2;
        }

        private void SomeFunc(Collider collider) {
            Debug.Log("Action: " + collider.gameObject.name);
        }

        private void SomeFunc2(Collider collider) {
            Debug.Log("Action 2: " + collider.gameObject.name);
        }

        public void PublicFunc(Collider collider) {
            Debug.Log("UnityEvent: " + collider.gameObject.name);
        }
    }
}
