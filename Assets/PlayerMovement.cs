using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 5f;

    private Rigidbody2D rb;

    public Vector2 movement;
    public bool canMove = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (canMove)
        {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector2(moveHorizontal, moveVertical).normalized;
    }
    }

    private void FixedUpdate()
    {
        //         if (DialogManager.GetInstance().dialogueIsPlaying)
        // {
        //     return;
        // }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    } 
}
