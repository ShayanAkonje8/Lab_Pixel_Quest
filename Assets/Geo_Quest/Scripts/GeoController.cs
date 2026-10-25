using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
        private Rigidbody2D rb;
    private SpriteRenderer sr;
        private int variable1 = 5;
        public int speed = 5;
    public string nextLevel = "Level2";
    
       string Var1 = "Hello";
        int var2 = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
      //Debug.Log(Var1 + " World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
           sr.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sr.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.color= Color.blue;
        }

        //Debug.Log(var2++);

        /* if (Input.GetKeyDown(KeyCode.W))
          {
              transform.position += new Vector3(0, 1, 0);
          }
          if (Input.GetKeyDown(KeyCode.A))
          {
              rb.velocity = new Vector2(-1, rb.velocity.y);
          }

          if (Input.GetKeyDown(KeyCode.S))
          {
              transform.position += new Vector3(0, -1, 0);
          }
          if (Input.GetKeyDown(KeyCode.D))
          {
              rb.velocity = new Vector2(1, rb.velocity.y);
          }
          */

        float xInput = Input.GetAxis("Horizontal");
        xInput *= variable1;
        //Debug.Log(xInput);

        rb.velocity = new Vector2(xInput, rb.velocity.y);
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        { 
                case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                   
                    SceneManager.LoadScene(thisLevel);
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
        Debug.Log("Hit");
    }
}

