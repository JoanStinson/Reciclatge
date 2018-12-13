using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUI : MonoBehaviour {

	private void Update () {
        if (Mathf.Sign((float)Game.pointss) == 1 || Mathf.Sign((float)Game.pointss) == 0) {
            if (Game.pointss > 999) GetComponent<Text>().text = "Score " + Game.pointss.ToString();
            else if (Game.pointss > 99) GetComponent<Text>().text = "Score 0" + Game.pointss.ToString();
            else if (Game.pointss > 9) GetComponent<Text>().text = "Score 00" + Game.pointss.ToString();
            else if (Game.pointss >= 0) GetComponent<Text>().text = "Score 000" + Game.pointss.ToString();
        }
        else if (Mathf.Sign((float)Game.pointss) == -1) {
            if (Game.pointss < -999) GetComponent<Text>().text = "Score -" + Mathf.Abs(Game.pointss).ToString();
            else if (Game.pointss < -99) GetComponent<Text>().text = "Score -0" + Mathf.Abs(Game.pointss).ToString();
            else if (Game.pointss < -9) GetComponent<Text>().text = "Score -00" + Mathf.Abs(Game.pointss).ToString();
            else if (Game.pointss < 0) GetComponent<Text>().text = "Score -000" + Mathf.Abs(Game.pointss).ToString();
        }
    }
}
