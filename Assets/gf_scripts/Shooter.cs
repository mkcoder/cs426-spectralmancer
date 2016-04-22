using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
    public Rigidbody    projectile;
    public Transform    projectilePos;
    public Rigidbody    skeleton;


    void Update () {

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Rigidbody missile = Instantiate(projectile, projectilePos.position, projectilePos.rotation) as Rigidbody;
            missile.AddForce(transform.forward * 200);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {

                Rigidbody summoned = Instantiate(skeleton, projectilePos.position, projectilePos.rotation) as Rigidbody;

        }
    }
}
