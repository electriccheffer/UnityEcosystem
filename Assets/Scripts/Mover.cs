using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 accelleration = new Vector3(0f,0f,0f);
    private Vector3 velocity = new Vector3(0f,0f,0f);
    public float  movementAmount = 1.0f;  
    private Vector3 forward;
    private Vector3 backward;
    private Vector3 left; 
    private Vector3 right;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	this.forward = new Vector3(movementAmount,0f,0f);
	this.backward = new Vector3(-movementAmount,0f,0f); 
	this.left = new Vector3(0f,0f,movementAmount);   	
	this.right = new Vector3(0f,0f,-movementAmount);     
    }

    // Update is called once per frame
    void Update()
    {
	
	if(Input.GetKey(KeyCode.W)){
		MoveInDirection(forward);
	}
	else if(Input.GetKey(KeyCode.S)){

		MoveInDirection(backward);
	}
	else if(Input.GetKey(KeyCode.D)){
	
		MoveInDirection(right);

	}
	else if(Input.GetKey(KeyCode.A)){
		MoveInDirection(left);

	}        
   	this.accelleration = new Vector3(0f,0f,0f); 
        this.velocity += this.accelleration;
    	this.transform.position += this.velocity;
    }

    void MoveInDirection(Vector3 direction){

	this.accelleration += direction; 
	this.velocity += this.accelleration; 		
	this.transform.position += this.velocity; 
    }
}
