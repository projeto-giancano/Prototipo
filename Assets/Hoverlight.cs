using UnityEngine;
using System.Collections;

public class Hoverlight : MonoBehaviour {

	private Color startcolor;
	void OnMouseEnter(){
		Debug.Log ("hi");
		startcolor = renderer.material.color;
		renderer.material.color = Color.red;
	}
	void OnMouseExit()
	{
		renderer.material.color = startcolor;
	}
}