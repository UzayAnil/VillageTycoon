using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float maxSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 velocity = new Vector2(horizontal * maxSpeed, vertical *maxSpeed);

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
