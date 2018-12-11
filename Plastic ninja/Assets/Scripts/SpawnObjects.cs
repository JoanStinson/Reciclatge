using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    // Use this for initialization
    public GameObject[] spawn;
    public float counter;
    int randObject;
    public static int spawnTime;
	void Start () {
        counter = 0;
        spawnTime = 30;
        randObject = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //GameManager.level;
      
        if (counter > spawnTime)
        {
            Debug.Log("x : " + transform.position.x + " y " + transform.position.y);
            randObject = Random.Range(0, 3);
            //Objetos que se spawnean;
            Instantiate(spawn[randObject], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
           //
            counter = 0;
            
        }
        else
        {

            counter++;
        }
        
        //Debug.Log(counter);
    }
}
