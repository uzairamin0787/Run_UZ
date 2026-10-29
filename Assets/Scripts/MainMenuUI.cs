using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject HowToPlayPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("03_Gameplay");
    }
    public void OpenSettings()
    {
        SettingsPanel.SetActive(true);
    }
    public void CloseSettings()
    {
        SettingsPanel.SetActive(false);
    }
    public void OpenHowToPlay()
    {
        HowToPlayPanel.SetActive(true);
    }
    public void CloseHowToPlay()
    {
        HowToPlayPanel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
