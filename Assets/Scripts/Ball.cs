using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public Transform _BallSpawnPointPosotion;
    public GameObject _PointToSpawnObject;
    public GameObject _SpawnObject;
    public float _speed;
    private int[] Goal = new int[2];
    public Text _myGoal, _EnemyGoal;
    public GameObject _ball;
    public Rigidbody2D _ballObject;
    public AudioSource _ballAudioSource;
    public GameObject _AfterMatchMenu;
    public GameObject _player;
    public GameObject _PlayerScore;
    public GameObject _EnemyScore;
    // Start is called before the first frame update

    private void Start()
    {
        _ballAudioSource.GetComponent<AudioSource>();
        _ballObject = GetComponent<Rigidbody2D>();
        _ball.transform.position = _BallSpawnPointPosotion.transform.position;
    }
    void Update()
    {
        _myGoal.text = Goal[0].ToString();
        _EnemyGoal.text = Goal[1].ToString();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "GOAL")
        {
            Goal[0] += 1;
            
            transform.position = _BallSpawnPointPosotion.transform.position;
            _ballObject.Sleep();
            if (Goal[0] ==10)
            {
                
                _AfterMatchMenu.SetActive(true);
                _player.SetActive(false);
                _ball.SetActive(false);
                _PlayerScore.SetActive(false);
                _EnemyScore.SetActive(false);
                

            }

        }
        else
        {
            if(other.tag == "EnemyGoal")
            {
                Goal[1] += 1;
                transform.position = _BallSpawnPointPosotion.transform.position;
                _ballObject.Sleep();
            }
        }

         if( other.tag == "Border")
        {
            _ballAudioSource.GetComponent <AudioSource>().Play();
        }
    }

  
}
