using UnityEngine;
using System.Collections;

public class Necromancer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.green;
    }
	
	// Update is called once per frame
	void Update() { }
        
}
