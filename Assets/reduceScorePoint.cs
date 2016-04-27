using UnityEngine;
using System.Collections;

public class reduceScorePoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision col)
    {
        // Debug.Log(col.gameObject.name + " has entered the cemetry!");
        if (col.gameObject.name.ToLower().Contains("teen") ||
            col.gameObject.name.ToLower().Contains("dog"))
        {
            Debug.Log("Teen or dog has entered the cemetry!");
            TimeText.entered();
        }
    }

    public void OnCollisionStay(Collision col)
    {

    }
    public void OnCollisionExit(Collision col)
    {

    }
}
