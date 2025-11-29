using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTriggerOne : MonoBehaviour
{
    public PlayableDirector timeLine;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeLine.Play();
        }
    }
}
