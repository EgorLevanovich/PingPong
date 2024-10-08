using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRestart : MonoBehaviour
{
    public GameObject _Restart;
    public GameObject _Home;
    // Start is called before the first frame update
   

    public void _RestartAction()
    {
        SceneManager.LoadScene("Game");
    }

    public void _HomeAction()
    {
        SceneManager.LoadScene("Menu");
    }
}
