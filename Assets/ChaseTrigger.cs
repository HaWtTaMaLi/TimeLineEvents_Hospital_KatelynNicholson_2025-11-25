using UnityEngine;

public class ChaseTrigger : MonoBehaviour
{
    public EnemyMovement enemy;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemy.ActivateChase();
        }
    }
}
