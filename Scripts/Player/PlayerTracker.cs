using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _yOffset;

    private void Update()
    {
        Vector3 targetPosition = new Vector3(_target.transform.position.x, _target.transform.position.y - _yOffset, transform.position.z);
        Vector3 newPosition = Vector3.Lerp(transform.position, targetPosition, _movementSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
