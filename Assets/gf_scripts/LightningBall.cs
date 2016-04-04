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
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject)
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
        if (bounceCounter == 0)
            Destroy(gameObject);
    }
}
