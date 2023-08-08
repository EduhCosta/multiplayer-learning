using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    private Canvas _gameOverCanvas;

    private void Start()
    {
        _gameOverCanvas = GetComponent<Canvas>();
    }

    private void OnEnable()
    {
        PlayerController.GameOverEvent += TurnOn;
    }

    private void OnDisable()
    {
        PlayerController.GameOverEvent -= TurnOn;
    }

    private void TurnOn()
    {
        _gameOverCanvas.enabled = true;
    }
}
