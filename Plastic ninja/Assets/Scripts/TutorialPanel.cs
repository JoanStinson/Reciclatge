using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
    public GameObject GlassPanel;
    public GameObject cartonPanel;
    public GameObject plasticPanel;
    public GameObject organicPanel;
    public GameObject grisPanel;
    public static bool gameStart;
    public GameObject tutorialPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameStart = false;

        if (Game.level == 1)
        {
            tutorialPanel.gameObject.SetActive(true);
            GlassPanel.gameObject.SetActive(false);
            cartonPanel.gameObject.SetActive(false);
            plasticPanel.gameObject.SetActive(false);
            organicPanel.gameObject.SetActive(false);
            grisPanel.gameObject.SetActive(false);
        }
        if (Game.level == 2)
        {
            tutorialPanel.gameObject.SetActive(false);
            GlassPanel.gameObject.SetActive(false);
            cartonPanel.gameObject.SetActive(false);
            plasticPanel.gameObject.SetActive(true);
            organicPanel.gameObject.SetActive(false);
            grisPanel.gameObject.SetActive(false);
        }
        if (Game.level == 3)
        {
            tutorialPanel.gameObject.SetActive(false);
            GlassPanel.gameObject.SetActive(false);
            cartonPanel.gameObject.SetActive(true);
            plasticPanel.gameObject.SetActive(false);
            organicPanel.gameObject.SetActive(false);
            grisPanel.gameObject.SetActive(false);
        }
        if (Game.level == 4)
        {
            tutorialPanel.gameObject.SetActive(false);
            GlassPanel.gameObject.SetActive(false);
            cartonPanel.gameObject.SetActive(false);
            plasticPanel.gameObject.SetActive(false);
            organicPanel.gameObject.SetActive(true);
            grisPanel.gameObject.SetActive(false);
        }
        if (Game.level == 5)
        {
            tutorialPanel.gameObject.SetActive(false);
            GlassPanel.gameObject.SetActive(false);
            cartonPanel.gameObject.SetActive(false);
            plasticPanel.gameObject.SetActive(false);
            organicPanel.gameObject.SetActive(false);
            grisPanel.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void closeGlassPanel()
    {
      
        GlassPanel.gameObject.SetActive(false); gameStart = true;
    }
    public void closeCartonPanel()
    {
        gameStart = true;
        cartonPanel.gameObject.SetActive(false);
    }
    public void closePlasticPanel()
    {
        gameStart = true;
        plasticPanel.gameObject.SetActive(false);
    }
    public void closeOrganicPanel()
    {
        gameStart = true;
        organicPanel.gameObject.SetActive(false);
    }
    public void closeGrisPanel()
    {
        gameStart = true;
        grisPanel.gameObject.SetActive(false);
    }
    public void closeTutorialPanel()
    {
        tutorialPanel.gameObject.SetActive(false);
        GlassPanel.gameObject.SetActive(true);
        cartonPanel.gameObject.SetActive(false);
        plasticPanel.gameObject.SetActive(false);
        organicPanel.gameObject.SetActive(false);
        grisPanel.gameObject.SetActive(false);
    }
}
