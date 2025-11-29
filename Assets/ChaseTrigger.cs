using UnityEngine;

public class ChaseTrigger : MonoBehaviour
{
    public EnemyMovement enemy;
    public GameObject monsterChase;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            monsterChase.SetActive(true);
            enemy.ActivateChase();
        }
    }
}
