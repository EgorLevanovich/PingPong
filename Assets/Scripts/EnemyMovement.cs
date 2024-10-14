using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject _ball;
    public int _speed;
    public float rotation_speed;
    public GameObject _enemy;
    public GameObject _Ball;


    public void Start()
    {
        _speed = 100;
    }

    private void Update()
    {
        

        if (_ball.transform.position.y >= 260 )
        {
            transform.position = Vector2.MoveTowards(transform.position, _ball.transform.position, _speed * Time.fixedDeltaTime);
        }
        
     


    }
}
