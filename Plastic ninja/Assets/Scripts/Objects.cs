using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour {

    Game.CONTENEDOR container;
    private Rigidbody2D rb;
    float rand;
    float randVX;
    float randVY;
    float randTime;
    float TimeCounter;

    public GameObject sumar;
    public GameObject restar;
    private void Start() {
        rb = transform.GetComponent<Rigidbody2D>();

        while (rand == 0){
            rand = Random.Range(-7, 7);
        }

        randVX = Random.Range(-5, 5);
        TimeCounter = 0;

    }

    private void Update() {

        rb.transform.position = new Vector2(randVX, transform.position.y);
        randTime = Random.Range(20, 30);
        transform.Rotate(Vector3.forward * rand);
        rb.gravityScale = -1.2f;

        if(TimeCounter > randTime) {
            rb.gravityScale = 1;
        }
        else {
            TimeCounter += 0.5f;
        }
        
        container = Game.contain;

        if (container == Game.CONTENEDOR.Vidrio) {

            if (Input.GetMouseButtonDown(0)) {

                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null) {
                 //   Debug.Log("Hiteado:" + hit.collider.gameObject.name);

                    if (hit.collider.tag == "Vidrio") {
                        GameObject Instantiated = Instantiate(sumar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Game.pointss += 5;
                        Destroy(hit.collider.gameObject);
                    }
                    else
                    {
                        GameObject Instantiated = Instantiate(restar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        Game.pointss -= 5;
                    //    Debug.Log("Restar puntos");
                        Destroy(hit.collider.gameObject);
                    }

                }
            }
        }
        else if (container == Game.CONTENEDOR.Plastico) {

            if (Input.GetMouseButtonDown(0)) {

                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null) {

                    if (hit.collider.tag == "Plastico")
                    {
                        GameObject Instantiated = Instantiate(sumar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Game.pointss += 5;
                        Destroy(hit.collider.gameObject);
                     //   Debug.Log(hit.collider.gameObject.name);
                        //SUMAR PUTNOS 
                    }
                    else
                    {
                        GameObject Instantiated = Instantiate(restar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Destroy(hit.collider.gameObject);
                        Game.pointss -= 5;
                        //RESTAR PUNTOS
                        //    Debug.Log("Restar puntos");
                    }

                }
            }
        }
        else if (container == Game.CONTENEDOR.Carton) {

            if (Input.GetMouseButtonDown(0)) 
                {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null) {

                    if (hit.collider.tag == "Carton")
                    {
                        GameObject Instantiated = Instantiate(sumar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Game.pointss += 5;
                        Destroy(hit.collider.gameObject);
                    //    Debug.Log(hit.collider.gameObject.name);
                    }
                    else
                    {
                        GameObject Instantiated = Instantiate(restar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Destroy(hit.collider.gameObject);
                        Game.pointss -= 5;
                        //      Debug.Log("Restar puntos");
                    }

                }
            }
        }
        else if (container == Game.CONTENEDOR.Organic)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null)
                {

                    if (hit.collider.tag == "Organic")
                    {
                        GameObject Instantiated = Instantiate(sumar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Game.pointss += 5;
                        Destroy(hit.collider.gameObject);
                        //    Debug.Log(hit.collider.gameObject.name);
                    }
                    else
                    {
                        GameObject Instantiated = Instantiate(restar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Destroy(hit.collider.gameObject);
                        Game.pointss -= 5;
                        //      Debug.Log("Restar puntos");
                    }

                }
            }
        }
        else if (container == Game.CONTENEDOR.General)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null)
                {

                    if (hit.collider.tag == "General")
                    {
                        GameObject Instantiated = Instantiate(sumar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Game.pointss += 5;
                        Destroy(hit.collider.gameObject);
                        //    Debug.Log(hit.collider.gameObject.name);
                    }
                    else
                    {
                        GameObject Instantiated = Instantiate(restar, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        Destroy(hit.collider.gameObject);
                        Game.pointss -= 5;
                        //      Debug.Log("Restar puntos");
                    }

                }
            }
        }

    }
}
