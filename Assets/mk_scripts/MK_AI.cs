using UnityEngine;
using System.Collections;

public class MK_AI : MonoBehaviour
{

    private GameObject teen;

	// Use this for initialization
	void Start ()
	{
	    iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("rightCornerWalkingPath"), "time", 1000));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
