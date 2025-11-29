using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTriggerThree : MonoBehaviour
{
    public PlayableDirector timeLine;
    public Animator rotateChair;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeLine.Play();
            rotateChair.SetTrigger("RotateChair");
        }
    }
}
