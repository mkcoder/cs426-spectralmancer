using System;
using UnityEngine;
using System.Collections;
using Random = System.Random;

/// <summary>
/// this generates Teens and Dogs at random (x,y,z) position and add a Path.
/// </summary>
public class Generator : MonoBehaviour
{
    public int limit = 10;
    


    GameObject _teen, _iTeen, _dog, _iDog;
    private float time;
    private float previousTimeRec;
    private int currentFrameCount = 0;
    private int tdPerSec = 10000;
    private int tdGenerate = 0;

    // Use this for initialization
    void Start ()
	{
	    TimeText t = (TimeText)(GameObject.Find("timer").GetComponent("TimeText"));
	    time = t.timeLeft;
	    previousTimeRec = 0;
        tdPerSec = (limit/ ((int)(time-5)))+1;
        Debug.Log(tdPerSec);
        Debug.Log(time);
        Debug.Log(limit);
        _dog  = GameObject.Find("dog");
        _teen = GameObject.Find("teen");
    }

    // Update is called once per frame
	void Update ()
	{
        if ( secondUpdated() && tdGenerate <= limit)
	        GenerateGameObject();
	}

    private bool secondUpdated()
    {
        previousTimeRec += Time.deltaTime;
        if (previousTimeRec >= 1)
        {
            previousTimeRec = 0;
            return true;
        }
        return false;
    }

    private void GenerateGameObject()
    {
        for (int i = 0; i < tdPerSec; i++)
        {
            var r = new Random();
            int randomNum = r.Next();
            if (randomNum%2==0)
            {
                _iTeen = (GameObject) Instantiate(_teen, new Vector3(13.4f, 2.358329f, 3.596587f), Quaternion.identity);
                _iTeen.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                MK_AI ai = (MK_AI) _iTeen.GetComponent("MK_AI");
                if (r.Next()%2 == 0)
                    ai.setPathChoice("leftToRight");
                ai.startWalk();
            }
            else
            {
                _iDog = (GameObject) Instantiate(_dog, new Vector3(13.4f, 2.358329f, 3.596587f), Quaternion.identity);
                _iDog.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                MK_AI ai = (MK_AI) _iDog.GetComponent("MK_AI");
                if (r.Next() % 2 == 0)
                    ai.setPathChoice("leftToRight");
                ai.startWalk();
            }
        }
        tdGenerate += tdPerSec;
    }
}
