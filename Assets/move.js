#pragma strict

var speed:float = 0.05;
function Start () {

}

function Update(){
	GetComponent.<Rigidbody2D>().velocity = Vector2(0,0);
}

function FixedUpdate () {
	
	if(Input.GetKey("w")){
		//transform.Translate(Vector2.up * speed * Time.deltaTime);
		GetComponent.<Rigidbody2D>().MovePosition(GetComponent.<Rigidbody2D>().position + Vector2.up * speed);
	}
	
	if(Input.GetKey("s")){
		//transform.Translate(Vector2.up * -speed * Time.deltaTime);
		GetComponent.<Rigidbody2D>().MovePosition(GetComponent.<Rigidbody2D>().position + Vector2.up * -speed); 
	}
	
	if(Input.GetKey("a")){
		//transform.Translate(Vector2.right * -speed * Time.deltaTime);
		GetComponent.<Rigidbody2D>().MovePosition(GetComponent.<Rigidbody2D>().position + Vector2.right * -speed); 
	}
	
	if(Input.GetKey("d")){
		//transform.Translate(Vector2.right * speed * Time.deltaTime);
		GetComponent.<Rigidbody2D>().MovePosition(GetComponent.<Rigidbody2D>().position + Vector2.right * speed); 
	}

}