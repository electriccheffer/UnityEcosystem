using UnityEngine;

public class Mover : MonoBehaviour
{
 
    public Vector3 velocity = new Vector3(0f,0f,0f); 	
    public Vector3 accelleration = new Vector3(1f,0f,0f);
	
   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        
	if(Input.GetKey(KeyCode.Space)){
	
		this.velocity += this.accelleration; 
                Debug.Log("Velocity: " + this.velocity); 
		this.transform.position += this.velocity; 
                this.accelleration = new Vector3(0f,0f,0f);
		Debug.Log("Accelleration: " + this.accelleration);
        }

    }
}
