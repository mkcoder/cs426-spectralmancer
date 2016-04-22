using UnityEngine;
using System.Collections.Generic;

public class skeleton_ai : MonoBehaviour {
    List<Transform> enemyList;
    float min;
    float dist;
    Transform target;


    // Use this for initialization
    void Start () {

        Object.Destroy(gameObject, 10.0f);
    }
	


	// Update is called once per frame
	//void Update () {
        /*enemyList.Clear();

        foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("teen"))
        {
            enemyList.Add(enemy.transform);
        }
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("dog"))
        {
            enemyList.Add(enemy.transform);
        }
        min = 9999999;
        foreach(Transform location in enemyList)
        {
            dist = Vector3.Distance(gameObject.transform.position, location.position);
            if (dist < min)
            {
                min = dist;
                target = location;
                transform.position = Vector3.MoveTowards(transform.position, target.position, 5 * Time.deltaTime);
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, 5 * Time.deltaTime);

        //transform.position = Vector3.MoveTowards(transform.position, target.position, 5 * Time.deltaTime);
        */
    //}


}
