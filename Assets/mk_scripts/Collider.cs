using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collider : MonoBehaviour
{
    public List<string> NamesList;


    // Use this for initialization
    void Start ()
    {
        if (GetComponent<Rigidbody>() == null)
        {
            var r = gameObject.AddComponent<Rigidbody>();
            r.useGravity = false;
            r.isKinematic = false;
            r.mass = 2.37f;
            r.drag = 6.67f;
            r.angularDrag = 2.66f;
            r.interpolation = RigidbodyInterpolation.None;
            ;
            r.collisionDetectionMode = CollisionDetectionMode.Discrete;

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision col)
    {
        if (canDestroy(col.gameObject.name))
        {
            Destroy(gameObject);
            Debug.Log(gameObject.name + " has [start] collidied");
        }
    }
    
    public void OnCollisionStay(Collision col)
    {
        if (canDestroy(col.gameObject.name))
        {
            // remove life points if possible 
            Debug.Log(gameObject.name + " has [stay] collidied");
        }
    }
    public void OnCollisionExit(Collision col)
    {
        if (canDestroy(col.gameObject.name))
        {
            // add a lighting sounds play here
            Debug.Log(gameObject.name + " has [exit] collidied");
        }
    }

    public bool canDestroy(string name)
    {
        return NamesList.Exists(_ => _.Equals(name));  
    }
}
