using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public GameObject _objectOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void OpenObject()
    {
        _objectOpen.SetActive(true);
    }

   public void CloseObject()
    {
        _objectOpen.SetActive(false);
    }

    public void ExitGame()
    {
       Application.Quit();
    }
}
