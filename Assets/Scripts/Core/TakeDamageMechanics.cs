using Elementary;
using UnityEngine;

public class TakeDamageMechanics : MonoBehaviour
{
    [SerializeField] private EventReceiver_Int damageReceiver;

    [SerializeField] private IntBehaviour hitPoints;

    private void OnEnable()
    {
        damageReceiver.OnEvent += OnAttack;
    }


    private void OnAttack(int damage)
    {
        hitPoints.Minus(damage);
    }
}