using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsButton : MonoBehaviour
{
    public GameObject _On;
    public GameObject _Off;
    public AudioSource _Source;
    // Start is called before the first frame update
    void Start()
    {
        _Source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonOffActive()
    {
        _Off.SetActive(true);
        _On.SetActive(false);
       
        _Source.GetComponent<AudioSource>().Pause();
    }

    public void ButtonOnActive()
    {
        _On.SetActive(true);
        _Off.SetActive(false);
        _Source.GetComponent<AudioSource>().UnPause();
    }
}
