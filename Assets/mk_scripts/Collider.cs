using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour
{
    public string col_name;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals(col_name))
        {
            Debug.Log(col_name + " has [enter] collidied");
            Destroy(gameObject);
        }
    }

    

    public void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name.Equals(col_name))
        {
            Debug.Log(col_name + " has [stay] collidied");
        }
    }
    public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name.Equals(col_name))
        {
            Debug.Log(col_name + " has [exit] collidied");
        }
    }
}
