using UnityEngine;

public class DisableTrigger : MonoBehaviour
{
    public GameObject monsterIdle;
    public GameObject olivia;
    public GameObject trigger; //because it has audio attached
    public Animator closeDoor;
    public AudioSource doorSound;
    public bool hasPlayed = false; //play once

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayed)
        {
            hasPlayed = true;
            monsterIdle.SetActive(false);
            olivia.SetActive(false);
            trigger.SetActive(false);
            closeDoor.Play("CloseDoor");
            doorSound.Play();
        }
    }
}
