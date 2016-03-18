using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform projectilePos;

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Q))
        {
            Rigidbody missile = Instantiate(projectile, projectilePos.position, projectilePos.rotation) as Rigidbody;
            missile.AddForce(transform.forward * 200);
        }
    }
}
