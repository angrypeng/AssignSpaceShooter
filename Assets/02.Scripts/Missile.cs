using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

	Transform target;
	public float speed = 0.1f;

	public void GetPos(Transform trans){
		target = trans;
	}

	void MissileControl(){
		Vector3 dir = target.position - transform.position;
		dir.Normalize ();

		Quaternion targetQ = Quaternion.LookRotation (dir);

		transform.rotation = Quaternion.Lerp (transform.rotation,
			targetQ,
			1.0f * Time.deltaTime);
		Vector3 pos = Vector3.forward * Time.deltaTime * 2.0f;
		transform.Translate (pos);
	}

	void On

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MissileControl ();
	}
}
