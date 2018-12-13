using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    private static bool isPause;

	private void Update () {
		Time.timeScale = isPause ? 0 : 1;
	}

    public void Pause() {
        isPause = !isPause;
    }
}
