using System;
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
        _dog  = GameObject.Find("dog");
        _teen = GameObject.Find("teen");
    }

    // Update is called once per frame
	void Update ()
	{
        if ( currentFrameCount++ % frameToGenerateTeenDog == 0 )
	        GenerateGameObject();
	}

    private void GenerateGameObject()
    {

        if (currentFrameCount%2 == 0)
        {
            _iTeen = (GameObject)Instantiate(_teen, new Vector3(13.4f, 2.358329f, 3.596587f), Quaternion.identity);
            _iTeen.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            MK_AI ai = (MK_AI)_iTeen.GetComponent("MK_AI");
            if (currentFrameCount % 4 == 0)
                ai.setPathChoice("leftToRight");
            ai.startWalk();
        }
        else
        {
            _iDog = (GameObject)Instantiate(_dog, new Vector3(13.4f, 2.358329f, 3.596587f), Quaternion.identity);
            _iDog.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            MK_AI ai = (MK_AI)_iDog.GetComponent("MK_AI");
            if (currentFrameCount % 16 == 0)
                ai.setPathChoice("leftToRight");
            ai.startWalk();
        }

    }
}
