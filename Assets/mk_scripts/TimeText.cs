using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeText : MonoBehaviour {

    // Use this for initialization
    public Text timeText;
    public float timeLeft = 30.0f;
    public int left = 0;

	void Start ()
	{
	    var generator = (Generator) GameObject.Find("Generators").GetComponent("Generator");
	    left = generator.limit;
        timeText.text = "Time: " + timeLeft;
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        timeText.text = "Time: " + (System.Math.Round(timeLeft, MidpointRounding.AwayFromZero));
        if ( timeLeft <= 0.0 )
        {            
            timeText.color = new Color(255, 0, 0);
            timeText.text = "LEVEL COMPLETED";
            SceneManager.LoadScene(2);
        }
    }

    public float getTime()
    {
        return timeLeft;        
    }

    public void killed()
    {
        this.left--;
        Debug.Log("Killed");
        Debug.Log(left);
    }
}
