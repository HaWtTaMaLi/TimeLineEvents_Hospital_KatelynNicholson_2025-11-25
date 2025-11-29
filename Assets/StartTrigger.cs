using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    public GameObject monsterIdle;
    public GameObject olivia;
    public GameObject trigger; //because it has audio attached

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            monsterIdle.SetActive(true);
            olivia.SetActive(true);
            trigger.SetActive(true);
        }
    }
}
