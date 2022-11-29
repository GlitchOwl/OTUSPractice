using CustomElementary;
using UnityEngine;

namespace Core.Mechanics
{
    public class MoveInDirectionMechanics : MonoBehaviour
    {
        [SerializeField] private EventReceiver_Vector3 directionReceiver;

        [SerializeField] private Transform visual;

        private void OnEnable()
        {
            directionReceiver.OnEvent += MoveInDirection;
        }

        private void OnDisable()
        {
            directionReceiver.OnEvent -= MoveInDirection;
        }

        private void MoveInDirection(Vector3 direction)
        {
            visual.position += direction;
        }
    }
}