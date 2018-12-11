using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vidrio" || collision.gameObject.tag == "Carton" || collision.gameObject.tag == "Plastico")
        {
            Debug.Log("hi");
            Destroy(collision.gameObject);
        }
        else
        {
          
            Debug.Log("noo");
            Debug.Log(collision.gameObject);

        }
    }
    
}
