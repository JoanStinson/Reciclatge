using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

 
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void level1()
    {
        Game.level = 1;
        SceneManager.LoadScene(1);
    }
    public void level2()
    {
        Game.level = 2;
        SceneManager.LoadScene(1);
    }
    public void level3()
    {
        Game.level = 3;
        SceneManager.LoadScene(1);
    }
}
