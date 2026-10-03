using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GeoController : MonoBehaviour
{
    string Var1 = "Hello";
    int var2 = 3;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      Debug.Log(Var1 + " World");
    }

    // Update is called once per frame
     void Update()
    {
        rb.velocity = new Vector2(-1, rb.velocity.y);
         
        Debug.Log(var2++);
        
       if (Input.GetKeyDown(KeyCode.W))
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
       
    }
}
