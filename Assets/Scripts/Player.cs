using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float ziplama_Gucu;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Sadece bir kez �al��mas� i�in down kodu kullan�ld�.
        {
            rb.velocity = Vector2.up * ziplama_Gucu;//Objemin h�z�n� yukar� y�nde art�r�yorum ve bunuda float bir de�erle �arp�yorum
        }
    }
}
