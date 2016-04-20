using UnityEngine;
using System.Collections;

public class enemyDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//change Player to the name of the controllable character
	public void onCollisionEnter (Collision node) {
		if(node.gameObject.name == "LightningBall" || node.gameObject.name == "Skeleton"
            || node.gameObject.tag == "Skeleton") {
			Destroy(gameObject);
		}
	}
}
