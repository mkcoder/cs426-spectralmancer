using UnityEngine;
using System.Collections.Generic;

public class skeleton_ai : MonoBehaviour {
    public AudioClip swords;
    AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();

        Object.Destroy(gameObject, 15.0f);
        
        StartCoroutine(deathCoroutine());
    }
	
    void Update ()
    {
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "dog" || col.gameObject.tag == "kitten".Substring(0, 6)
            || col.gameObject.tag == "teen")
        {
            this.GetComponent<Animation>().Play("attack");
            audio.PlayOneShot(swords, 1);
        }
        else if (col.gameObject.tag == "lightning")
            Object.Destroy(gameObject);
    }

    System.Collections.IEnumerator deathCoroutine()
    {
        yield return new WaitForSeconds(13);
        this.GetComponent<Animation>().Play("die");
    }
}
