using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private Transform _beginPosition;
    [SerializeField] private Transform _endPosition;

    public Transform Begin => _beginPosition;
    public Transform End => _endPosition;

}
