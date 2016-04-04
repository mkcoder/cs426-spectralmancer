using UnityEngine;
using System.Collections;

public class LightningBall : MonoBehaviour {
    private int bounceCounter;
    private Rigidbody rb;
    public  int lightningSpeed = 200;
    	
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        gameObject.name = "LightningBall";
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.yellow;
        bounceCounter = 3;
        Object.Destroy(gameObject, 3.0f);
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "kitt_Body1" || collision.gameObject.tag == "dog" ||
            collision.gameObject.tag == "teen" || collision.gameObject.tag == "tombstone" ||
            collision.gameObject.tag.Substring(0,4) == "Fence")
        {
            --bounceCounter;

            if (bounceCounter == 0)
                Destroy(gameObject);
        }

    }

    void FixedUpdate ()
    {
        rb.velocity = lightningSpeed * (rb.velocity.normalized);
    
    }

    void Update () {

    }
}
