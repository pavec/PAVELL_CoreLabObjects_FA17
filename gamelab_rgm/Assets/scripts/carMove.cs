using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour {


	public float speed = 0;
	public float force = 6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCollisionEnter (Collision other){

		float distance = speed * Time.deltaTime;
		transform.Translate (distance, 0, 0);

	}
}
