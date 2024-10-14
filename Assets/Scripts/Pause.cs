using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsService : MonoBehaviour
{
    [SerializeField] private GameObject _settingsWindow;
    
    [SerializeField] private Button _openButton;
    [SerializeField] private Button _closeButton;
    [SerializeField] private Button _exitButton;

    private const string MenuSceneName = "Menu";

    private void Start()
    {
        _openButton.onClick.AddListener(OpenSettings);
        _closeButton.onClick.AddListener(CloseSettings);
        _exitButton.onClick.AddListener(ExitToMenu);
    }

    private void OpenSettings()
    {
        Time.timeScale = 0f;
        _settingsWindow.SetActive(true);
    }

    private void CloseSettings()
    {
        Time.timeScale = 1f;
        _settingsWindow.SetActive(false);
    }

    private void ExitToMenu()
    {
        CloseSettings();
        SceneManager.LoadScene(MenuSceneName);
    }
}
