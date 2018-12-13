using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnObjects : MonoBehaviour {

    public GameObject[] spawn;
    public float counter;
    int randObject;
    public static float spawnTime;
    public int CounterElement;
    public int maxElement;
    public int maxPoints;
    public int points;
    public GameObject gameEndPanel;

    private void Start() {
        counter = 0;
        randObject = 0;

        switch (Game.level) {
            case 1:
                CounterElement = 0;
                maxElement = 100;
            break;
        }

    }

    private void Update() {

        //print(CounterElement);
        switch (Game.level) {
            case 1:
                maxPoints = PlayerPrefs.GetInt("Level1MAX");
                Debug.Log("MAX"+PlayerPrefs.GetInt("Level1MAX"));

                if (counter > spawnTime) {

                    randObject = Random.Range(0, 3);
                    // Objetos que se spawnean
                    GameObject Instantiated = Instantiate(spawn[randObject], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                    if (Instantiated.tag == "Vidrio") {
                        CounterElement += 1;
                    }
                    counter = 0;
                }
                else {
                    counter += Time.deltaTime;
                }

            if (CounterElement == 10) { //TODO cambiar

                if (Game.pointss > maxPoints) {
                    maxPoints = Game.pointss;
                    PlayerPrefs.SetInt("Level1MAX", Game.pointss);
                }

                // Game end
                gameEndPanel.SetActive(true);
            }
            break;
        }
   
    }
        
}
