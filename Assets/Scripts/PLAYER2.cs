using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player2 : MonoBehaviour
{
    public float velocidade = 3.5f;
    void Update()
    {




        float verticalMovement = 0f;
        if(Input.GetKey(KeyCode.S))
        {
            verticalMovement = -1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            verticalMovement = 1;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalMovement * velocidade);
    }
} 