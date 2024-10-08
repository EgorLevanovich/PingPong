using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject _ball;
    public float _speed;
    public float rotation_speed;
    public GameObject _enemy;

   



    private void Update()
    {
        

        if (_ball.transform.position.y >= 0.50 )
        {
            transform.position = Vector2.MoveTowards(transform.position, _ball.transform.position, _speed * Time.deltaTime);
        }
        
     


    }
}
