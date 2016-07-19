using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public float coolTimer = 90;
    private Text timerText;
	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        coolTimer -= Time.deltaTime;
        string minutes = ((int)coolTimer / 60).ToString();
        string seconds = (coolTimer % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

        if (coolTimer <= 0)
            timerText.text = "Game Over";
    }
}
