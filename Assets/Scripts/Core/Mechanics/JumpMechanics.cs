using System.Collections;
using Elementary;
using UnityEngine;

namespace Core.Mechanics
{
    public class JumpMechanics : MonoBehaviour
    {
        [SerializeField] private Transform visual;

        [SerializeField] private EventReceiver_Float jumpReceiver;

        [SerializeField] private FloatBehaviour speedFloatBehaviour;

        private void OnEnable()
        {
            jumpReceiver.OnEvent += OnJump;
        }

        private void OnDisable()
        {
            jumpReceiver.OnEvent -= OnJump;
        }

        private void OnJump(float height)
        {
            StartCoroutine(Jump(height, speedFloatBehaviour.Value));
        }

        IEnumerator Jump(float height, float speed)
        {
            Vector3 startPos = visual.position;
            Vector3 endPos = startPos + Vector3.up * height;

            while (visual.position != endPos)
            {
                visual.position = Vector3.MoveTowards(visual.position, endPos, speed * Time.deltaTime);
                yield return null;
            }

            while (visual.position != startPos)
            {
                visual.position = Vector3.MoveTowards(visual.position, startPos, speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}