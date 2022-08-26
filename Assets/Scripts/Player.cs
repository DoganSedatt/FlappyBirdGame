using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float ziplama_Gucu;
    Rigidbody2D rb;
    public GameManager managerGame;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//Sadece bir kez çalýþmasý için down kodu kullanýldý.
        {
            rb.velocity = Vector2.up * ziplama_Gucu;//Objemin hýzýný yukarý yönde artýrýyorum ve bunuda float bir deðerle çarpýyorum
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ScoreArea")
        {
            managerGame.Score();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {
            Time.timeScale = 0;
            managerGame.Dead();
        }
    }
}
