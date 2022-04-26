using UnityEngine;
using TMPro;

public class DisplayMeters : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _meters;

    private float _metersCount = 0;

    private void Update()
    {
        _metersCount = (int) _player.transform.position.y;
        _meters.text = _metersCount.ToString();
    }
}
