using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class bp_ai : MonoBehaviour {

	List<Transform> tombstoneList;
	public float targetDistance;
	private float stopPosition = 2;
	public float enemySightDistance;
	public float attackDistance;
	public float enemySpeed;
	public float damping;
	private Animation anim;
	public Transform target;
	Rigidbody aRigidbody;
	Renderer render;

	// Use this for initialization
	void Start () {
		render = GetComponent<Renderer>();
		tombstoneList = new List<Transform>();
		anim = GetComponent<Animation>();

		foreach(GameObject tombstone in GameObject.FindGameObjectsWithTag("tombstone")) {
			tombstoneList.Add(tombstone.transform);
		}

			int num = tombstoneList.Count;
			System.Random rand = new System.Random();
			int randGen = rand.Next(0, num);

			target = tombstoneList[randGen];
	}
	
	// Update is called once per frame
	void Update () {
		targetDistance = Vector3.Distance (target.position, transform.position);
		if (targetDistance < enemySightDistance) {
			lookAt();
		}
		if ((targetDistance < attackDistance) && (targetDistance > stopPosition)) {
			attack ();
			anim.Play ("Run");
		} else {
			anim.Play("Idle");
		}
	}

	void lookAt() {
		Quaternion rotation = Quaternion.LookRotation (target.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping);
	}

	void attack() {
		transform.Translate (Vector3.forward * enemySpeed * Time.deltaTime);
	}

}//end public class bp_ai...
