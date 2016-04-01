using System;
using UnityEngine;
using System.Collections;

public class MK_AI : MonoBehaviour
{

    private GameObject teen;
    public int time;
    private string _pathChoice = "rightCornerWalkingPath";

    public void setPathChoice(string pathChoice)
    {
        _pathChoice = pathChoice;
    }

    public void startWalk()
    {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(_pathChoice), "time", time));
    }

	// Use this for initialization
	void Start ()
	{	    
	}    

	// Update is called once per frame
	void Update () {
	
	}
}
