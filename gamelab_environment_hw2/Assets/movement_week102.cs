using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_week102 : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		float move = Input.GetAxisRaw("Vertical") * 0.3f;
		float rotate = Input.GetAxisRaw("Horizontal") *5;

		Debug.Log (move);
		transform.Translate (move, 0, 0);
		transform.Rotate (rotate, 0, 0);

	}
}
