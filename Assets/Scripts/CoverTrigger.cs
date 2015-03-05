using UnityEngine;
using System.Collections;

public class CoverTrigger : MonoBehaviour {

	Animator anim;
	bool cover;
	bool coverT;

	// Use this for initialization
	void Start () {
		move move = GetComponent<move> ();
		move.anim = GetComponent<Animator> ();
		cover = false;
	}
	
	// Update is called once per frame
	void Update () {
		Covering ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "player") {
			coverT = true;
			
		}
	}

	void OnTriggerExit2D(Collider2D other){
		coverT = false;
		cover = false;
		move.anim.SetBool("cover", false);
	}

	void Covering(){
		if (coverT) {
			if (Input.GetKeyDown ("space")) {
				cover = !cover;
				Debug.Log (cover);
			}
			if (cover == true) {
				move.anim.SetBool ("cover", true);
			} else {
				move.anim.SetBool ("cover", false);
			}
		}
	}
}
