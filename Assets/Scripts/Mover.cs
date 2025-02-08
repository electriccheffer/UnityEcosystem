using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 accelleration = new Vector3(0f,0f,0f);
    private Vector3 velocity = new Vector3(0f,0f,0f);
    public float  movementAmount;  
    private Vector3 forward;
    private Vector3 backward;
    private Vector3 left; 
    private Vector3 right;
    private float friction; 
    public float frictionMagnitudeThreshold; 

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
		
	if(Input.GetKeyDown(KeyCode.W)){
		ApplyFriction(this.forward);
	}
	else if(Input.GetKeyDown(KeyCode.S)){
		ApplyFriction(this.backward);
	}
	else if(Input.GetKeyDown(KeyCode.D)){
		ApplyFriction(this.right);
	}
	else if(Input.GetKeyDown(KeyCode.A)){
		ApplyFriction(this.left);
	}        
	else{
	
		if(accelleration.magnitude > frictionMagnitudeThreshold){
		
			ApplyFriction(this.accelleration);
		}	
		else{
			this.accelleration = Vector3.zero; 
			this.velocity = this.accelleration; 
			this.transform.position += this.velocity;
 
		}	
	} 
	
    }

    void MoveInDirection(Vector3 direction){

	this.accelleration += direction; 
	this.velocity += this.accelleration; 		
	this.transform.position += this.velocity; 
    	Debug.Log("Current accelleration: " + this.accelleration);
	Debug.Log("Current velocity: " + this.velocity);
	Debug.Log("Current position: " + this.transform.position);
    }
    
    void ApplyFriction(Vector3 currentDirection){
	Vector3 currentDirectionForce = currentDirection.normalized; 	
	Debug.Log("Normalized Direction: " +  currentDirectionForce );
	Debug.Log("Current friction force: " + (-this.friction * currentDirectionForce));
	MoveInDirection(currentDirection - (this.friction * currentDirectionForce));		

    }

    void OnCollisionEnter(Collision groundCollision){

	this.friction = groundCollision.gameObject.GetComponent<Friction>().getForce(); 
	Debug.Log("Current Friction " + this.friction);	
    }
}
