using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed;

    public int health = 5;
     

    private Rigidbody2D rb;

    private Vector2 moveVelocity;

    private void Start()
    {
        rb = GetComponent< Rigidbody2D>();
       rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {

        if (health == 0)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        //if  (health == 0) { Destroy(this); }

       
    }

     void FixedUpdate()
    {
        rb.MovePosition(rb.position + (moveVelocity * Time.fixedDeltaTime));
        //if (health <= 0)
        //{

        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //}

    }



}
