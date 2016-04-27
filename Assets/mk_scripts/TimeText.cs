using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = System.Object;

public class TimeText : MonoBehaviour {

    // Use this for initialization
    public Text timeText;
    public float timeLeft = 30.0f;
    private static int left = 0;
    private static int userScore = 0;
    private int totalPossibleScore = 0;
    static Object o_lock = new Object();
    static Object o_lock2 = new Object();

    void Start ()
    {
        left = 0;
        userScore = 0;
        var generator = (Generator) GameObject.Find("Generators").GetComponent("Generator");
        totalPossibleScore = left = generator.limit;
        timeText.text = "Time: " + timeLeft;
	}
	
	// Update is called once per frame
	void Update () {
        if (left == 0)
        {
            timeText.color = new Color(255, 0, 0);
            timeText.text = "LEVEL COMPLETED";
            left = 0;
            userScore = 0;
            SceneManager.LoadScene(3);
        }

        if (userScore >= left)
        {

            Debug.Log("User score is greater than >= " + totalPossibleScore);
            timeText.color = new Color(255, 0, 0);
            timeText.text = "You lost :(!";
            left = 0;
            userScore = 0;
            SceneManager.LoadScene(2);
        }

        timeLeft -= Time.deltaTime;

	    timeText.text = buildTextString();
            

        if ( timeLeft <= 0.0 )
        {
            // dfa3c81
            if (left == 0)
            {
                timeText.color = new Color(255, 0, 0);
                timeText.text = "LEVEL COMPLETED";
                left = 0;
                userScore = 0;
                SceneManager.LoadScene(3);
            }
            else
            {
                timeText.color = new Color(255, 0, 0);
                timeText.text = "LEVEL COMPLETED";
                left = 0;
                userScore = 0;
                SceneManager.LoadScene(2);
            }
        }
    }

    private string buildTextString()
    {
        return String.Format("Time: {0} Score: {1} Enemies Left: {2}",
         System.Math.Round(timeLeft, MidpointRounding.AwayFromZero),
         userScore, left);
    }

    public float getTime()
    {
        return timeLeft;        
    }

    public static void killed()
    {
        lock (o_lock)
        {
            left--;
            Debug.Log("Killed");
            Debug.Log(left);
        }
    }

    public static void entered()
    {
        lock (o_lock2)
        {
            userScore++;
            Debug.Log("User Score: ");
            Debug.Log(userScore);
        }
    }
}
