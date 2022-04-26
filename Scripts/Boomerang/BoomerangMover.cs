using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Boomerang))]
public class BoomerangMover : MonoBehaviour
{
    private float _movementSpeed = 0.5f;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        TryMove();
    }

    private void TryMove()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                _rigidbody.velocity = new Vector2(touch.deltaPosition.x * _movementSpeed, touch.deltaPosition.y * _movementSpeed);
            }
        } 
        else
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }
}
