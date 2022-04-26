using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScreen : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _panel;

    private void OnEnable()
    {
        _player.PlayerDied += OnPlayerDied;
    }

    private void OnDisable()
    {
        _player.PlayerDied -= OnPlayerDied;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }

    private void OnPlayerDied()
    {
        _panel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
