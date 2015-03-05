using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	float moveSpeed = 3.5f;
	public static Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();



	}

	void Movement() {
		Vector2 pos = transform.position;
		Quaternion rot = transform.rotation;
		pos.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		transform.position = pos;


		anim.SetFloat ("speed", Mathf.Abs(Input.GetAxis ("Horizontal")));

		if (Input.GetAxis ("Horizontal") > 0) {
			//anim.SetBool("cover", false);
			rot.y = 0;
			transform.rotation = rot;
		}

		if (Input.GetAxis ("Horizontal") < 0){
			//anim.SetBool("cover", false);
			rot.y = 180;
			transform.rotation = rot;
		}
	}
}
