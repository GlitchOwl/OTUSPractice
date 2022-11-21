using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Elementary
{
    public sealed class EventReceiver_Bundle : MonoBehaviour
    {
        public event Action<Bundle> OnEvent;

        [PropertySpace(8)]
        [GUIColor(0, 1, 0)]
        [Button]
        public void Call(Bundle bundle)
        {
            this.OnEvent?.Invoke(bundle);
        }
    }
}