using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityAction PlayerDied;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            Die();
        }
    }

    private void Die()
    {
        PlayerDied?.Invoke();
        Destroy(gameObject);
    }
}
