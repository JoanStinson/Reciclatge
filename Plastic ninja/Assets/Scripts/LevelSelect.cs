using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

    public void Level1() {
        Game.level = 1;
        SceneManager.LoadScene(2);
    }

    public void Level2() {
        Game.level = 2;
        SceneManager.LoadScene(2);
    }

    public void Level3() {
        Game.level = 3;
        SceneManager.LoadScene(2);
    }

    public void Level4() {
        Game.level = 4;
        SceneManager.LoadScene(2);
    }

    public void Level5() {
        Game.level = 5;
        SceneManager.LoadScene(2);
    }
}
