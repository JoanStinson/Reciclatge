using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    Game.CONTENEDOR container;
    private Rigidbody2D rb;
    float rand;
    float randVX;
    float randVY;
    float randTime;
    float TimeCounter;
    // Use this for initialization
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        while (rand == 0)
        {
            rand = Random.Range(-7, 7);
        }
        randVX = Random.Range(-5, 5);
        TimeCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = new Vector2(randVX, transform.position.y);
        randTime = Random.Range(20, 30);
     transform.Rotate(Vector3.forward * rand);
        rb.gravityScale = -1.2f;

        if(TimeCounter > randTime)
        {
            rb.gravityScale = 1;
         
        }
        else
        {
            TimeCounter += 0.5f;
        }
        
        container = Game.contain;
        if (container == Game.CONTENEDOR.Vidrio)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider != null)
                {
                 //   Debug.Log("Hiteado:" + hit.collider.gameObject.name);
                    if (hit.collider.tag == "Vidrio")
                    {
                        Game.pointss += 5;
                       
                        Destroy(hit.collider.gameObject);
                    }
                    else
                    {
                        Game.pointss -= 5;
                    //    Debug.Log("Restar puntos");
                        Destroy(hit.collider.gameObject);
                    }

                }
            }
        }
        else if (container == Game.CONTENEDOR.Plastico)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider != null)
                {
                    if (hit.collider.tag == "Plastico")
                    {
                        Game.pointss += 5;
                        Destroy(hit.collider.gameObject);
                     //   Debug.Log(hit.collider.gameObject.name);
                        //SUMAR PUTNOS 
                    }
                    else
                    {
                        Destroy(hit.collider.gameObject);
                        //RESTAR PUNTOS
                    //    Debug.Log("Restar puntos");
                    }

                }
            }
        }
        else if (container == Game.CONTENEDOR.Carton)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider != null)
                {
                    if (hit.collider.tag == "Carton")
                    {
                        Game.pointss += 5;
                        Destroy(hit.collider.gameObject);
                    //    Debug.Log(hit.collider.gameObject.name);
                    }
                    else
                    {
                        Destroy(hit.collider.gameObject);
                  //      Debug.Log("Restar puntos");
                    }

                }
            }
        }

    }
}
