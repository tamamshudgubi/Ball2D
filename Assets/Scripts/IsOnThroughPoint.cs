using UnityEngine;
using UnityEngine.Events;

public class IsOnThroughPoint : MonoBehaviour
{
    public GameObject Groundcreator;
    public GameObject BGWider;

    public UnityEvent CreateEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = GetComponent<PlayerController>();

        if (player != null)
        {
            CreateEvent.Invoke();
        }
    }
}
