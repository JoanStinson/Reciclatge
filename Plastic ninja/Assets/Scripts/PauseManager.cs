using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    private static bool isPause;
    public GameObject pausePanel;

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
        isPause = false;
        SceneManager.LoadScene(2);
    }

    public void LevelSelect() {
        isPause = false;
        SceneManager.LoadScene(1);
    }

    public void MainMenu() {
        isPause = false;
        SceneManager.LoadScene(0);
    }
}
