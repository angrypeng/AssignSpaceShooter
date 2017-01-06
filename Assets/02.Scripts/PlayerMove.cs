using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public GameObject missile;
	public Transform firePos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp ("Fire1")) {
			GameObject fire = Instantiate (missile) as GameObject;
			fire.transform.position = firePos.position;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit hit;

			if(Physics.Raycast(ray, out hit)){
				if(hit.transform.tag.Equals("Enemy")){
					fire.GetComponent<Missile> ().GetPos(hit.transform);
					Debug.Log (hit.transform.position);
				}
			}

		}
	}
}
