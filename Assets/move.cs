using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	float moveSpeed = 3.5f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (transform.position);

		Vector2 pos = transform.position;
		pos.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		transform.position = pos;

	}
}
