using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeText : MonoBehaviour {

    // Use this for initialization
    public Text timeText;
    public float timeLeft = 30.0f;

	void Start () {
        timeText.text = "Time: " + timeLeft;
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timeText.text = "Time: " + timeLeft;
        if ( timeLeft <= 0.0 )
        {
            timeText.color = new Color(255, 0, 0);
            timeText.text = "LEVEL COMPLETED";
        }
    }
}
