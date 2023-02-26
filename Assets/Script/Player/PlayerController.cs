using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // pr�dko�� poruszania si� gracza
    public Rigidbody2D rb; // Rigidbody2D gracza
    private Vector2 moveDirection; // kierunek poruszania si� gracza

    // funkcja wywo�ywana przy starcie
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // funkcja wywo�ywana co ka�d� klatk�
    void Update()
    {
        // pobieranie wej�cia z klawiatury
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // ustalanie kierunku poruszania si� gracza
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

    // funkcja wywo�ywana z sta�� cz�stotliwo�ci�
    void FixedUpdate()
    {
        // poruszanie si� gracza
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
}
