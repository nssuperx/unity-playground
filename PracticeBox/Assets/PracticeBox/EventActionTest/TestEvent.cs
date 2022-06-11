using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace EventActionTest {
    public class TestEvent : MonoBehaviour {

        [SerializeField] public event Action<Collider> action;
        [SerializeField] UnityEngine.Events.UnityEvent<Collider> Event;

        private void OnTriggerEnter(Collider collider) {
            // action(collider);
            action?.Invoke(collider);
            Event?.Invoke(collider);
        }
    }
}
