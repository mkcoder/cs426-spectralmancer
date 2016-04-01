using UnityEngine;
using System.Collections;

/// <summary>
/// this generates Teens and Dogs at random (x,y,z) position and add a Path.
/// </summary>
public class Generator : MonoBehaviour
{
    GameObject _teen, _iTeen, _dog, _iDog;


    public int frameToGenerateTeenDog = 10000;
    private int currentFrameCount = 0;

    // Use this for initialization
	void Start ()
	{
	    // create a teen
	    for (int i = 0; i < 1; i++)
        {
            _dog = GameObject.Find("dog");
            _teen = GameObject.Find("teen");
            _iTeen = (GameObject)Instantiate(_teen, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            _iTeen.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
	}

    // Update is called once per frame
	void Update ()
	{
        if ( currentFrameCount++ % frameToGenerateTeenDog == 0 )
	        GenerateGameObject();
	}

    private void GenerateGameObject()
    {
        // create a teen
        for (int i = 0; i < 1; i++)
        {
            _iTeen = (GameObject)Instantiate(_teen, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            _iTeen.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

    }
}
