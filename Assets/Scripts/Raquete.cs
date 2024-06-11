using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Raquete : MonoBehaviour
{
    public float velocidade = 3.5f;
    void Update()
    {
        float verticalMovement = 0;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalMovement = -1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalMovement = 1;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalMovement * velocidade);
    }
}
