using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScene : MonoBehaviour {

    public Text GotPoints;
    public int points;

    private void Start() {
        switch (Game.level) {
            case 1:
                points = PlayerPrefs.GetInt("Level1MAX");
                break;
        }
    }

    private void Update() {

        switch (Game.level) {
            case 1:
             GotPoints.text = points.ToString();
                if(points > 350) {
                    //medalla oro
                }
                if (points > 150) {
                    //medalla plata
                }
                if (points < 0) {
                    //medalla bronce
                }
                break;
        }
    }
}
