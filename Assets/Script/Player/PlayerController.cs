using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // prêdkoœæ poruszania siê gracza
    public Rigidbody2D rb; // Rigidbody2D gracza
    private Vector2 moveDirection; // kierunek poruszania siê gracza

    // funkcja wywo³ywana przy starcie
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // funkcja wywo³ywana co ka¿d¹ klatkê
    void Update()
    {
        // pobieranie wejœcia z klawiatury
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // ustalanie kierunku poruszania siê gracza
        moveDirection = new Vector2(moveX, moveY).normalized;

        // odtwarzanie animacji ruchu
        /*
        if (moveX != 0 || moveY != 0)
        {
            GetComponent<Animator>().SetBool("isWalking", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("isWalking", false);
        }
        */
    }

    // funkcja wywo³ywana z sta³¹ czêstotliwoœci¹
    void FixedUpdate()
    {
        // poruszanie siê gracza
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
