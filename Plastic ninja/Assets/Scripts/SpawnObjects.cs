using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SpawnObjects : MonoBehaviour {

    public GameObject[] spawn;
    public float counter;
    int randObject;
    int randElement;
    public static float spawnTime;
    public int CounterElement;
    public int maxElement;
    public int maxPoints;
    public int points;
    public GameObject gameEndPanel;
    public Text textHighScore;
    public GameObject[] vidrioSpawn;
    public GameObject[] PlasticSpawn;
    public GameObject[] CartonSpawn;
    public GameObject[] OrganicSpawn;
    public GameObject[] GeneralSpawn;
    private void Start() {

    counter = 0;
        randObject = 0;

        switch (Game.level) {
            case 1:
                CounterElement = 0;
                maxElement = 100;

            break;
            case 2:
                CounterElement = 0;
                maxElement = 100;
                break;
            case 3:
                CounterElement = 0;
                maxElement = 100;
                break;
            case 4:
                CounterElement = 0;
                maxElement = 100;
                break;
            case 5:
                CounterElement = 0;
                maxElement = 100;
                break;
        }

    }

    private void Update() {
      
        //print(CounterElement); 
        Debug.Log(CounterElement + " ELEMENTO: " + Game.contain);
        switch (Game.level) {
            case 1:
                if (CounterElement < 20)
                {
                    maxPoints = PlayerPrefs.GetInt("Level1MAX");
                    //Debug.Log("MAX"+PlayerPrefs.GetInt("Level1MAX"));
                    textHighScore.text = maxPoints.ToString();
                    if (counter > spawnTime)
                    {

                        randObject = Random.Range(0, 5);
                        // Objetos que se spawnean
                        Debug.Log("OBJ Fuera random " +  randObject);
                        if(randObject == 0)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("VIDRIO SPAWNED");
                            Debug.Log("OBJ: " + randObject + "VIDRIO SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(vidrioSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                            if (Instantiated.tag == "Vidrio")
                            {
                                CounterElement += 1;
                            }
                        }
                        if (randObject == 1)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("PLASTIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(PlasticSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject == 2)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("CARTON SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(CartonSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject == 3)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("ORGANIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "ORGANIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(OrganicSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject == 4)
                        {
                            randElement = Random.Range(0, 7);
                            Debug.Log("GRIS SPAWNED");
                            Debug.Log("OBJ: " + randObject + "GRIS SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(GeneralSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject > 4)
                        {
                            Debug.Log("ERROR");
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter += Time.deltaTime;
                    }
                }
            if (CounterElement == 20) { //TODO cambiar

                if (Game.pointss > maxPoints) {
                    maxPoints = Game.pointss;
                    PlayerPrefs.SetInt("Level1MAX", Game.pointss);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("Level1MAX", maxPoints);
                    }
                // Game end
                gameEndPanel.SetActive(true);
            }
            break;
            case 2:
                if (CounterElement < 20)
                {
                    maxPoints = PlayerPrefs.GetInt("Level2MAX");
                    //Debug.Log("MAX"+PlayerPrefs.GetInt("Level1MAX"));
                    textHighScore.text = maxPoints.ToString();
                    if (counter > spawnTime)
                    {

                        randObject = Random.Range(0, 4);
                        // Objetos que se spawnean
                        Debug.Log("OBJ Fuera random " + randObject);
                        if (randObject == 0)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("VIDRIO SPAWNED");
                            Debug.Log("OBJ: " + randObject + "VIDRIO SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(vidrioSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                          
                        }
                        if (randObject == 1)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("PLASTIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(PlasticSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                            if (Instantiated.tag == "Plastico")
                            {
                                CounterElement += 1;
                            }
                        }
                        if (randObject == 2)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("CARTON SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(CartonSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject == 3)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("ORGANIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "ORGANIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(OrganicSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject == 4)
                        {
                            randElement = Random.Range(0, 7);
                            Debug.Log("GRIS SPAWNED");
                            Debug.Log("OBJ: " + randObject + "GRIS SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(GeneralSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject > 4)
                        {
                            Debug.Log("ERROR");
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter += Time.deltaTime;
                    }
                }
                if (CounterElement == 20)
                { //TODO cambiar

                    if (Game.pointss > maxPoints)
                    {
                        maxPoints = Game.pointss;
                        PlayerPrefs.SetInt("Level2MAX", Game.pointss);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("Level2MAX", maxPoints);
                    }
                    // Game end
                    gameEndPanel.SetActive(true);
                }
                break;
            case 3:
                if (CounterElement < 25)
                {
                    maxPoints = PlayerPrefs.GetInt("Level3MAX");
                    //Debug.Log("MAX"+PlayerPrefs.GetInt("Level1MAX"));
                    textHighScore.text = maxPoints.ToString();
                    if (counter > spawnTime)
                    {

                        randObject = Random.Range(0, 4);
                        Debug.Log("OBJ Fuera random " + randObject);
                        if (randObject == 0)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("VIDRIO SPAWNED");
                            Debug.Log("OBJ: " + randObject + "VIDRIO SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(vidrioSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                           
                        }
                        if (randObject == 1)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("PLASTIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(PlasticSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                       
                        }
                        if(randObject == 2)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("CARTON SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(CartonSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                            if (Instantiated.tag == "Carton")
                            {
                                CounterElement += 1;
                            }

                        }
                        if (randObject == 3)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("ORGANIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "ORGANIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(OrganicSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject == 4)
                        {
                            randElement = Random.Range(0, 7);
                            Debug.Log("GRIS SPAWNED");
                            Debug.Log("OBJ: " + randObject + "GRIS SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(GeneralSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject > 4)
                        {
                            Debug.Log("ERROR");
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter += Time.deltaTime;
                    }
                }
                if (CounterElement == 25)
                { //TODO cambiar

                    if (Game.pointss > maxPoints)
                    {
                        maxPoints = Game.pointss;
                        PlayerPrefs.SetInt("Level3MAX", Game.pointss);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("Level3MAX", maxPoints);
                    }
                    // Game end
                    gameEndPanel.SetActive(true);
                }
                break;
            case 4:
                if (CounterElement < 25)
                {
                    maxPoints = PlayerPrefs.GetInt("Level4MAX");
                    //Debug.Log("MAX"+PlayerPrefs.GetInt("Level1MAX"));
                    textHighScore.text = maxPoints.ToString();
                    if (counter > spawnTime)
                    {

                        randObject = Random.Range(0, 4);
                        Debug.Log("OBJ Fuera random " + randObject);
                        if (randObject == 0)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("VIDRIO SPAWNED");
                            Debug.Log("OBJ: " + randObject + "VIDRIO SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(vidrioSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        }
                        if (randObject == 1)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("PLASTIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(PlasticSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        }
                        if (randObject == 2)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("CARTON SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(CartonSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                          

                        }
                        if (randObject == 3)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("ORGANIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "ORGANIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(OrganicSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                            if (Instantiated.tag == "Organic")
                            {
                                CounterElement += 1;
                            }
                        }
                        if (randObject == 4)
                        {
                            randElement = Random.Range(0, 7);
                            Debug.Log("GRIS SPAWNED");
                            Debug.Log("OBJ: " + randObject + "GRIS SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(GeneralSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                        }
                        if (randObject > 4)
                        {
                            Debug.Log("ERROR");
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter += Time.deltaTime;
                    }
                }
                if (CounterElement == 25)
                { //TODO cambiar

                    if (Game.pointss > maxPoints)
                    {
                        maxPoints = Game.pointss;
                        PlayerPrefs.SetInt("Level4MAX", Game.pointss);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("Level4MAX", maxPoints);
                    }
                    // Game end
                    gameEndPanel.SetActive(true);
                }
                break;
            case 5:
                if (CounterElement < 10)
                {
                    maxPoints = PlayerPrefs.GetInt("Level5MAX");
                    //Debug.Log("MAX"+PlayerPrefs.GetInt("Level1MAX"));
                    textHighScore.text = maxPoints.ToString();
                    if (counter > spawnTime)
                    {

                        randObject = Random.Range(0, 4);
                        Debug.Log("OBJ Fuera random " + randObject);
                        if (randObject == 0)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("VIDRIO SPAWNED");
                            Debug.Log("OBJ: " + randObject + "VIDRIO SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(vidrioSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        }
                        if (randObject == 1)
                        {
                            randElement = Random.Range(0, 6);
                            Debug.Log("PLASTIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(PlasticSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);

                        }
                        if (randObject == 2)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("CARTON SPAWNED");
                            Debug.Log("OBJ: " + randObject + "PLASTIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(CartonSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);


                        }
                        if (randObject == 3)
                        {
                            randElement = Random.Range(0, 5);
                            Debug.Log("ORGANIC SPAWNED");
                            Debug.Log("OBJ: " + randObject + "ORGANIC SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(OrganicSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                           
                        }
                        if (randObject == 4)
                        {
                            randElement = Random.Range(0, 7);
                            Debug.Log("GRIS SPAWNED");
                            Debug.Log("OBJ: " + randObject + "GRIS SPAWNED " + randElement);
                            GameObject Instantiated = Instantiate(GeneralSpawn[randElement], new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                            if (Instantiated.tag == "General")
                            {
                                CounterElement += 1;
                            }
                        }
                        if (randObject > 4)
                        {
                            Debug.Log("ERROR");
                        }
                        counter = 0;
                    }
                    else
                    {
                        counter += Time.deltaTime;
                    }
                }
                if (CounterElement == 25)
                { //TODO cambiar

                    if (Game.pointss > maxPoints)
                    {
                        maxPoints = Game.pointss;
                        PlayerPrefs.SetInt("Level5MAX", Game.pointss);
                    }
                    else
                    {
                        PlayerPrefs.SetInt("Level5MAX", maxPoints);
                    }
                    // Game end
                    gameEndPanel.SetActive(true);
                }
                break;

        }
   
    }
        
}
