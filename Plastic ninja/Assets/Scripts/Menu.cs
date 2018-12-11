using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    public void Play() {
        SceneManager.LoadScene(1);
    }

    public void Medals() {

    }

    public void Exit() {
        Application.Quit();
    }

    public void Level1() {
        Game.level = 1;
        SceneManager.LoadScene(1);
    }

    public void Level2() {
        Game.level = 2;
        SceneManager.LoadScene(1);
    }

    public void level3() {
        Game.level = 3;
        SceneManager.LoadScene(1);
    }
}
