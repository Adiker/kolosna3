using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    public float speed; //zmienna do podania pr�dko�ci poruszania
    public float jump; //zmienna do podania do mocy skoku
    Rigidbody2D rb; //Rigidbody do fizyki naszego playera
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //nadajemy naszej zmiennej w�a�ciwo�ci Rigidbody
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump")) //na rozpocz�ciu akcji skosku (naci�niecie spacji)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));//dodanie si�y skoku do fizyki gracza
        }
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");//pobranie/ zaznaczenie ze bierzemy o�
        Vector2 move = new Vector2(x * speed, rb.velocity.y);//utworzenie 
        rb.velocity = move;//dodanie tego ruchu do naszego gracza 
    }
}