using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelect : MonoBehaviour {
    public GameObject Level1MedalBronze;
    public GameObject Level1MedalSilver;
    public GameObject Level1MedalGold;

    public GameObject Level2MedalBronze;
    public GameObject Level2MedalSilver;
    public GameObject Level2MedalGold;

    public GameObject Level3MedalBronze;
    public GameObject Level3MedalSilver;
    public GameObject Level3MedalGold;

    public GameObject Level4MedalBronze;
    public GameObject Level4MedalSilver;
    public GameObject Level4MedalGold;

    public GameObject Level5MedalBronze;
    public GameObject Level5MedalSilver;
    public GameObject Level5MedalGold;
    public int Level1Medals;
    public int Level2Medals;
    public int Level3Medals;
    public int Level4Medals;
    public int Level5Medals;

    public Button level2Button;
    public Button level3Button;
    public Button level4Button;
    public Button level5Button;
    public int totalMedals;
    public void Start()
    {
        Level1MedalBronze.gameObject.SetActive(false);
        Level1MedalSilver.gameObject.SetActive(false);
        Level1MedalGold.gameObject.SetActive(false);

        Level2MedalBronze.gameObject.SetActive(false);
        Level2MedalSilver.gameObject.SetActive(false);
        Level2MedalGold.gameObject.SetActive(false);

        Level3MedalBronze.gameObject.SetActive(false);
        Level3MedalSilver.gameObject.SetActive(false);
        Level3MedalGold.gameObject.SetActive(false);

        Level4MedalBronze.gameObject.SetActive(false);
        Level4MedalSilver.gameObject.SetActive(false);
        Level4MedalGold.gameObject.SetActive(false);

        Level5MedalBronze.gameObject.SetActive(false);
        Level5MedalSilver.gameObject.SetActive(false);
        Level5MedalGold.gameObject.SetActive(false);
        Level1Medals = PlayerPrefs.GetInt("Level1Medals");
        Level2Medals = PlayerPrefs.GetInt("Level2Medals");
        Level3Medals = PlayerPrefs.GetInt("Level3Medals");
        Level4Medals = PlayerPrefs.GetInt("Level4Medals");
        Level5Medals = PlayerPrefs.GetInt("Level5Medals");
        totalMedals = Level1Medals + Level2Medals + Level3Medals +Level4Medals + Level5Medals;
        Debug.Log("Medallas totales: " + totalMedals + " = " + "Nivel 1: " + Level1Medals + " Nivel 2: "+ Level2Medals + "Nivel 3: " + Level3Medals + " Nivel 4: " + Level4Medals
                    + " Nivel 5: " + Level5Medals);
        if (Level1Medals == 3)
        {
            Level1MedalBronze.gameObject.SetActive(true);
            Level1MedalSilver.gameObject.SetActive(true);
            Level1MedalGold.gameObject.SetActive(true);
        }
        if (Level1Medals == 2)
        {
            Level1MedalBronze.gameObject.SetActive(true);
            Level1MedalSilver.gameObject.SetActive(true);
            Level1MedalGold.gameObject.SetActive(false);
        }
        if (Level1Medals == 1)
        {
            Level1MedalBronze.gameObject.SetActive(true);
            Level1MedalSilver.gameObject.SetActive(false);
            Level1MedalGold.gameObject.SetActive(false);
        }
        if (Level2Medals == 3)
        {
            Level2MedalBronze.gameObject.SetActive(true);
            Level2MedalSilver.gameObject.SetActive(true);
            Level2MedalGold.gameObject.SetActive(true);
        }
        if (Level2Medals == 2)
        {
            Level2MedalBronze.gameObject.SetActive(true);
            Level2MedalSilver.gameObject.SetActive(true);
            Level2MedalGold.gameObject.SetActive(false);
        }
        if (Level2Medals == 1)
        {
            Level2MedalBronze.gameObject.SetActive(true);
            Level2MedalSilver.gameObject.SetActive(false);
            Level2MedalGold.gameObject.SetActive(false);
        }
        if (Level3Medals == 3)
        {
            Level3MedalBronze.gameObject.SetActive(true);
            Level3MedalSilver.gameObject.SetActive(true);
            Level3MedalGold.gameObject.SetActive(true);
        }
        if (Level3Medals == 2)
        {
            Level3MedalBronze.gameObject.SetActive(true);
            Level3MedalSilver.gameObject.SetActive(true);
            Level3MedalGold.gameObject.SetActive(false);
        }
        if (Level3Medals == 1)
        {
            Level3MedalBronze.gameObject.SetActive(true);
            Level3MedalSilver.gameObject.SetActive(false);
            Level3MedalGold.gameObject.SetActive(false);
        }
        if (Level4Medals == 3)
        {
            Level4MedalBronze.gameObject.SetActive(true);
            Level4MedalSilver.gameObject.SetActive(true);
            Level4MedalGold.gameObject.SetActive(true);
        }
        if (Level4Medals == 2)
        {
            Level4MedalBronze.gameObject.SetActive(true);
            Level4MedalSilver.gameObject.SetActive(true);
            Level4MedalGold.gameObject.SetActive(false);
        }
        if (Level4Medals == 1)
        {
            Level4MedalBronze.gameObject.SetActive(true);
            Level4MedalSilver.gameObject.SetActive(false);
            Level4MedalGold.gameObject.SetActive(false);
        }
        if (Level5Medals == 3)
        {
            Level5MedalBronze.gameObject.SetActive(true);
            Level5MedalSilver.gameObject.SetActive(true);
            Level5MedalGold.gameObject.SetActive(true);
        }
        if (Level5Medals == 2)
        {
            Level5MedalBronze.gameObject.SetActive(true);
            Level5MedalSilver.gameObject.SetActive(true);
            Level5MedalGold.gameObject.SetActive(false);
        }
        if (Level5Medals == 1)
        {
            Level5MedalBronze.gameObject.SetActive(true);
            Level5MedalSilver.gameObject.SetActive(false);
            Level5MedalGold.gameObject.SetActive(false);
        }
        switch (totalMedals)
        {
            case 0:
                level5Button.interactable = false;
                level4Button.interactable = false;
                level3Button.interactable = false;
                level2Button.interactable = false;
                break;
            case 1:
                level5Button.interactable = false;
                level4Button.interactable = false;
                level3Button.interactable = false;
                level2Button.interactable = false;
                break;
            case 2:
                level5Button.interactable = false;
                level4Button.interactable = false;
                level3Button.interactable = false;
                level2Button.interactable = true;
                break;
            case 3:
                level5Button.interactable = false;
                level4Button.interactable = false;
                level3Button.interactable = false;
                level2Button.interactable = true;
                break;
            case 4:
                level5Button.interactable = false;
                level4Button.interactable = false;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 5:
                level5Button.interactable = false;
                level4Button.interactable = false;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 6:
                level5Button.interactable = false;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 7:
                level5Button.interactable = false;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 8:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 9:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 10:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 11:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 12:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 13:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 14:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
            case 15:
                level5Button.interactable = true;
                level4Button.interactable = true;
                level3Button.interactable = true;
                level2Button.interactable = true;
                break;
        }
      
    }
    void Update()
    {
       

    }
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
