using UnityEngine;
using UnityEngine.Events;

public class IsPlayerOnThroughPoint : MonoBehaviour
{
    private UnityEvent GroundCreating;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player != null)
        {
            GroundCreating.Invoke();
        }
    }
}
