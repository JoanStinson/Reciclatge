using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    private static bool isPause;
    public GameObject pausePanel;
    public GameObject gameEndPanel;

	private void Update () {
		Time.timeScale = isPause ? 0 : 1;
        pausePanel.SetActive(isPause);
	}

    public void Pause() {
        isPause = !isPause;
    }

    public void Resume() {
        isPause = false;
    }

    public void Restart() {
        gameEndPanel.SetActive(false);
        isPause = false;
        SceneManager.LoadScene(2);
    }

    public void LevelSelect() {
        gameEndPanel.SetActive(false);
        isPause = false;
        switch(Game.level)
        {
            case 1:
            Game.contain = Game.CONTENEDOR.Vidrio;
            SpawnObjects.spawnTime = 1f; //SE PUEDE CAMBIAR SEGUN LA DIFICULTAD QUE QUERRAMOS METER!! TIEMPO DE SPAWN ENTRE OBJETOS
                break;
            case 2:
                Game.contain = Game.CONTENEDOR.Plastico;
                SpawnObjects.spawnTime = 1f;
                break;
            case 3:
                Game.contain = Game.CONTENEDOR.Carton;
                SpawnObjects.spawnTime = 1f;
                break;
            case 4:
                Game.contain = Game.CONTENEDOR.Organic;
                SpawnObjects.spawnTime = 1f;
                break;
            case 5:
                Game.contain = Game.CONTENEDOR.General;
                SpawnObjects.spawnTime = 1f;
                break;
        }
        SceneManager.LoadScene(1);
    }

    public void MainMenu() {
        gameEndPanel.SetActive(false);
        isPause = false;
        SceneManager.LoadScene(0);
    }
}
