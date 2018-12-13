using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public GameObject medalsPanel;

    public void Play() {
        SceneManager.LoadScene(1);
    }

    public void Medals() {
        medalsPanel.SetActive(true);
    }

    public void Exit() {
        Application.Quit();
    }

    public void CloseMedalsPanel() {
        medalsPanel.SetActive(false);
    }
}
