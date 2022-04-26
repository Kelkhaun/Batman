using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Obstacle : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Boomerang light))
        {
            _rigidbody.isKinematic = false;
        }

        if (collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            _rigidbody.isKinematic = false;
        }
    }
}
