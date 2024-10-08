using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Controller : MonoBehaviour
{

    bool wasJustClicked = true;
    bool canMove;
    Vector2 playerSize;
    private Rigidbody2D _rb;
    public static Vector2 SpawnPointPosition = new Vector2(-2, 332);
    [SerializeField] private Rigidbody2D[] _players;
    


    // Use this for initialization
    void Start()
    {
        int index = PlayerPrefs.GetInt(PlayerSelect.SkinKey);
        for (int i = 0; i < _players.Length; i++)
        {
            if (i == index)
            {
                _rb = _players[i];
                _rb.gameObject.SetActive(true);

            }
            else
            {
                _players[i].gameObject.SetActive(false);
            }
        }
            
       
        playerSize = Vector2.one;
    }

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (wasJustClicked )
            {
                wasJustClicked = false;


                if ((mousePos.x >= _rb.position.x && mousePos.x < _rb.position.x + playerSize.x ||
                mousePos.x <= _rb.position.x && mousePos.x > _rb.position.x - playerSize.x) &&
                (mousePos.y >= _rb.position.y && mousePos.y < _rb.position.y + playerSize.y ||
                mousePos.y <= _rb.position.y && mousePos.y > _rb.position.y - playerSize.y))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

           

            if (canMove)
            {
                
                _rb.MovePosition(mousePos);
            }
        }
        else
        {
            wasJustClicked = true;
        }
    }
}
