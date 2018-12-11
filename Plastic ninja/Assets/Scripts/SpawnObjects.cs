using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawnObjects : MonoBehaviour {

    // Use this for initialization
    public GameObject[] spawn;
    public float counter;
    int randObject;
    public static int spawnTime;
    public int CounterElement;
    public int maxElement;

    public int maxPoints;
    public int points;
    void Start() {
        counter = 0;
        randObject = 0;
        switch (Game.level)
        {
            case 1:
        CounterElement = 0;
        maxElement = 100;
                break;
        }

    }

    // Update is called once per frame
    void Update() {
        //GameManager.level;
        switch (Game.level) {
            case 1:
               maxPoints = PlayerPrefs.GetInt("Level1MAX");
                Debug.Log("MAX"+PlayerPrefs.GetInt("Level1MAX"));
                if (counter > spawnTime)
        {
            //   Debug.Log("x : " + transform.position.x + " y " + transform.position.y);
            randObject = Random.Range(0, 3);
            //Objetos que se spawnean;
            GameObject Instantiated = Instantiate(spawn[randObject], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            if (Instantiated.tag == "Vidrio");
            {
                        CounterElement += 1;
            }
            counter = 0;
        }
        else
        {
            counter++;
        }
        if (CounterElement == 20)
        {
          if (Game.pointss > maxPoints)
           {
                        maxPoints = Game.pointss;
           PlayerPrefs.SetInt("Level1MAX", Game.pointss);
          }
            SceneManager.LoadScene(2);
        }
                break;
        }
   


        }
        
        //Debug.Log(counter);
}
