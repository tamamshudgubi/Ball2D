using UnityEngine;
using UnityEngine.Events;

public class IsOnThroughPoint : MonoBehaviour
{
    public UnityEvent CreateEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            CreateEvent.Invoke();
        }
    }
}
