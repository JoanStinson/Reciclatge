using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalsPanel : MonoBehaviour
{
    public int Lv1medals;
    public int Lv2medals;
    public int Lv3medals;
    public int Lv4medals;
    public int Lv5medals;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Lv1medals= PlayerPrefs.GetInt("Level1Medals");
        Lv2medals = PlayerPrefs.GetInt("Level2Medals");
        Lv3medals = PlayerPrefs.GetInt("Level3Medals");
        Lv4medals = PlayerPrefs.GetInt("Level4Medals");
        Lv5medals = PlayerPrefs.GetInt("Level5Medals");

        if(Lv1medals == 0)
        {
            Level1MedalBronze.gameObject.SetActive(false);
            Level1MedalSilver.gameObject.SetActive(false);
            Level1MedalGold.gameObject.SetActive(false);
        }
        if (Lv1medals == 1)
        {
            Level1MedalBronze.gameObject.SetActive(true);
            Level1MedalSilver.gameObject.SetActive(false);
            Level1MedalGold.gameObject.SetActive(false);
        }
        if (Lv1medals == 2)
        {
            Level1MedalBronze.gameObject.SetActive(true);
            Level1MedalSilver.gameObject.SetActive(true);
            Level1MedalGold.gameObject.SetActive(false);
        }
        if (Lv1medals == 3)
        {
            Level1MedalBronze.gameObject.SetActive(true);
            Level1MedalSilver.gameObject.SetActive(true);
            Level1MedalGold.gameObject.SetActive(true);
        }

        if (Lv2medals == 0)
        {
            Level2MedalBronze.gameObject.SetActive(false);
            Level2MedalSilver.gameObject.SetActive(false);
            Level2MedalGold.gameObject.SetActive(false);
        }
        if (Lv2medals == 1)
        {
            Level2MedalBronze.gameObject.SetActive(true);
            Level2MedalSilver.gameObject.SetActive(false);
            Level2MedalGold.gameObject.SetActive(false);
        }
        if (Lv2medals == 2)
        {
            Level2MedalBronze.gameObject.SetActive(true);
            Level2MedalSilver.gameObject.SetActive(true);
            Level2MedalGold.gameObject.SetActive(false);
        }
        if (Lv2medals == 3)
        {
            Level2MedalBronze.gameObject.SetActive(true);
            Level2MedalSilver.gameObject.SetActive(true);
            Level2MedalGold.gameObject.SetActive(true);
        }
        if (Lv3medals == 0)
        {
            Level3MedalBronze.gameObject.SetActive(false);
            Level3MedalSilver.gameObject.SetActive(false);
            Level3MedalGold.gameObject.SetActive(false);
        }
        if (Lv3medals == 1)
        {
            Level3MedalBronze.gameObject.SetActive(true);
            Level3MedalSilver.gameObject.SetActive(false);
            Level3MedalGold.gameObject.SetActive(false);
        }
        if (Lv3medals == 2)
        {
            Level3MedalBronze.gameObject.SetActive(true);
            Level3MedalSilver.gameObject.SetActive(true);
            Level3MedalGold.gameObject.SetActive(false);
        }
        if (Lv3medals == 3)
        {
            Level3MedalBronze.gameObject.SetActive(true);
            Level3MedalSilver.gameObject.SetActive(true);
            Level3MedalGold.gameObject.SetActive(true);
        }
        if (Lv4medals == 0)
        {
            Level4MedalBronze.gameObject.SetActive(false);
            Level4MedalSilver.gameObject.SetActive(false);
            Level4MedalGold.gameObject.SetActive(false);
        }
        if (Lv4medals == 1)
        {
            Level4MedalBronze.gameObject.SetActive(true);
            Level4MedalSilver.gameObject.SetActive(false);
            Level4MedalGold.gameObject.SetActive(false);
        }
        if (Lv4medals == 2)
        {
            Level4MedalBronze.gameObject.SetActive(true);
            Level4MedalSilver.gameObject.SetActive(true);
            Level4MedalGold.gameObject.SetActive(false);
        }
        if (Lv4medals == 3)
        {
            Level4MedalBronze.gameObject.SetActive(true);
            Level4MedalSilver.gameObject.SetActive(true);
            Level4MedalGold.gameObject.SetActive(true);
        }
        if (Lv5medals == 0)
        {
            Level5MedalBronze.gameObject.SetActive(false);
            Level5MedalSilver.gameObject.SetActive(false);
            Level5MedalGold.gameObject.SetActive(false);
        }
        if (Lv5medals == 1)
        {
            Level5MedalBronze.gameObject.SetActive(true);
            Level5MedalSilver.gameObject.SetActive(false);
            Level5MedalGold.gameObject.SetActive(false);
        }
        if (Lv5medals == 2)
        {
            Level5MedalBronze.gameObject.SetActive(true);
            Level1MedalSilver.gameObject.SetActive(true);
            Level1MedalGold.gameObject.SetActive(false);
        }
        if (Lv5medals == 3)
        {
            Level5MedalBronze.gameObject.SetActive(true);
            Level5MedalSilver.gameObject.SetActive(true);
            Level5MedalGold.gameObject.SetActive(true);
        }
    }
}
