using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace CustomElementary
{
    public sealed class EventReceiver_Vector3 : MonoBehaviour
    {
        public event Action<Vector3> OnEvent;

        [PropertySpace(8)]
        [GUIColor(0, 1, 0)]
        [Button]
        public void Call(Vector3 value)
        {
            this.OnEvent?.Invoke(value);
        }
    }
}