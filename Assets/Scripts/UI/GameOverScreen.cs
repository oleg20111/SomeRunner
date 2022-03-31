using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private CanvasGroup _gameOverGroup;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Player _player;

    private void Start()
    {
        _gameOverGroup.alpha = 0;
        _gameOverGroup.blocksRaycasts = false;
    }

    private void OnEnable()
    {
        _player.Died += OnDied;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _exitButton.onClick.RemoveListener(OnExitButtonClick);
    }

    private void OnDied()
    {
        _gameOverGroup.alpha = 1;
         _gameOverGroup.blocksRaycasts = true;
        Time.timeScale = 0;
    }

    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }
}
