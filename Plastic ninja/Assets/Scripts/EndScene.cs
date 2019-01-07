using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScene : MonoBehaviour {

    public Text GotPoints;
    public int points;
    public GameObject medalBronze;
    public GameObject medalGold;
    public GameObject medalSilver;
    private void Start() {
        switch (Game.level) {
            case 1:
                points = PlayerPrefs.GetInt("Level1MAX");
                break;
            case 2:
                points = PlayerPrefs.GetInt("Level2MAX");
                break;
            case 3:
                points = PlayerPrefs.GetInt("Level3MAX");
                break;
            case 4:
                points = PlayerPrefs.GetInt("Level4MAX");
                break;
            case 5:
                points = PlayerPrefs.GetInt("Level5MAX");
                break;
        }
    }

    private void Update() {

        switch (Game.level) {
            case 1:
             GotPoints.text = "HIGSCHORE: " + points.ToString();
                if(points >= 85) {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(true);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level1Medals", 3);
                }
                if (points >= 55 && points < 85) {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level1Medals", 2);
                }
                if (points >= 25 && points < 55) {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(false);
                    PlayerPrefs.SetInt("Level1Medals", 1);
                }
                break;
            case 2:
                GotPoints.text = "HIGSCHORE: " + points.ToString();
                if (points >= 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(true);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level2Medals", 3);
                }
                if (points >= 55 && points < 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level2Medals", 2);
                }
                if (points >= 25 && points < 55)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(false);
                    PlayerPrefs.SetInt("Level2Medals", 1);
                }
                break;
            case 3:
                GotPoints.text = "HIGSCHORE: " + points.ToString();
                if (points >= 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(true);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level3Medals", 3);
                }
                if (points >= 55 && points < 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level3Medals", 2);
                }
                if (points >= 25 && points < 55)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(false);
                    PlayerPrefs.SetInt("Level3Medals", 1);
                }
                break;
            case 4:
                GotPoints.text = "HIGSCHORE: " + points.ToString();
                if (points >= 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(true);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level4Medals", 3);
                }
                if (points >= 55 && points < 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level4Medals", 2);
                }
                if (points >= 25 && points < 55)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(false);
                    PlayerPrefs.SetInt("Level4Medals", 1);
                }
                break;
            case 5:
                GotPoints.text = "HIGSCHORE: " + points.ToString();
                if (points >= 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(true);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level5Medals", 3);
                }
                if (points >= 55 && points < 85)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(true);
                    PlayerPrefs.SetInt("Level5Medals", 2);
                }
                if (points >= 25 && points < 55)
                {
                    medalBronze.SetActive(true);
                    medalGold.SetActive(false);
                    medalSilver.SetActive(false);
                    PlayerPrefs.SetInt("Level5Medals", 1);
                }
                break;
        }
    }
}
