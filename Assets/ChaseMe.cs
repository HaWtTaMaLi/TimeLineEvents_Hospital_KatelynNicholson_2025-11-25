using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent monsterRunner;
    public bool chasePlayer = false;

    public void Start()
    {
        monsterRunner = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        if (chasePlayer && player != null)
        {
            monsterRunner.SetDestination(player.position);
        }
    }

    public void ActivateChase()
    {
        chasePlayer = true;
    }
}
