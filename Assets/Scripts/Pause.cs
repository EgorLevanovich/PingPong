using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject _menuOpen;
    public GameObject _Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void PauseButton()
    {
        
        Time.timeScale = 0f;
        _menuOpen.SetActive(true);

    }

    public void ResumeGame()
    {
        _menuOpen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitTheGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
