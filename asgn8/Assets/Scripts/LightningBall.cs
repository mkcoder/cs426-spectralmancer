using UnityEngine;
using System.Collections;

public class LightningBall : MonoBehaviour {
    private int bounceCount = 3;
    private int magnitude;
    private Rigidbody lightning;
    private float x;
    private float y;
    private float z;
    

	// Use this for initialization
	void Start () {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.blue;
        lightning = gameObject.GetComponent<Rigidbody>();

        x = lightning.transform.eulerAngles.x;
        y = lightning.transform.eulerAngles.y;
        z = lightning.transform.eulerAngles.z;
    }
	
	// Update is called once per frame
	void Update () {
        if (x != lightning.transform.eulerAngles.x || y != lightning.transform.eulerAngles.y ||
            z != lightning.transform.eulerAngles.z)
        {
            Destroy(lightning);
        }
        
      
    }
    

}
