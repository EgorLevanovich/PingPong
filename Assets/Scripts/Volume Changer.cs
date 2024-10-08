using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    private AudioSource _audioSource;
    private float valuemusic = 1f;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        _audioSource.volume = valuemusic;

    }

    public void VolumeChangerValue(float vol)
    {

        valuemusic = vol;
    }
}
