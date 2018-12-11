using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsUI : MonoBehaviour {

    public Text text;
    public static int pointss;
	// Use this for initialization
	void Start () {


        pointss = 10;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = pointss.ToString();
    }
}
