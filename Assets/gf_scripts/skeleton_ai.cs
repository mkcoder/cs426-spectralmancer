using UnityEngine;
using System.Collections.Generic;

public class skeleton_ai : MonoBehaviour {
    public AudioClip swords;
    AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        Object.Destroy(gameObject, 10.0f);
    }
	
    void Update ()
    {

    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "dog" || col.gameObject.tag == "kitten".Substring(0, 6))
        {
            this.GetComponent<Animation>().Play("attack");
            audio.PlayOneShot(swords, 1);
        }
    }

}
