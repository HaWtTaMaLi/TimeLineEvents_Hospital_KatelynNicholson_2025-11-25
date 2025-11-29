using UnityEngine;

public class DisableTrigger : MonoBehaviour
{
    public GameObject monsterIdle;
    public GameObject olivia;
    public GameObject trigger; //because it has audio attached
    public Animator closeDoor;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            monsterIdle.SetActive(false);
            olivia.SetActive(false);
            trigger.SetActive(false);
            closeDoor.SetTrigger("CloseDoor");
        }
    }
}
