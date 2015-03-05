using UnityEngine;
using System.Collections;

public class Hoverlight : MonoBehaviour {

	private Color startcolor;
	void OnMouseEnter(){
		Debug.Log ("hi");
		startcolor = GetComponent<Renderer>().material.color;
		GetComponent<Renderer>().material.color = Color.red;
	}
	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = startcolor;
	}
}