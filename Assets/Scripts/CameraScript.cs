using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float elapsedTime; 
    public float rotationSpeed; 
    public bool rotateCamera;
    public int focusOn;  
    public float rotateCameraAt;
    public float moveCameraTime;  
    public float moveCameraAt; 
    public Vector3 blueBall = new Vector3(-10f,10f,2f); 
    public Vector3 redBall = new Vector3(-16f,10f,-7f);
    public Vector3 yellowBall = new Vector3(2f,10f,-7f);
    public float moveSpeed; 
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.rotateCamera = true; 
    	this.focusOn = 0; 
    	this.elapsedTime = 0f; 
    	this.moveCameraAt = 5f;
	this.moveCameraTime = 8f; 
    }

    // Update is called once per frame
    void Update()
    {
	this.elapsedTime += Time.deltaTime; 

	if(this.elapsedTime >= this.moveCameraAt){
			
		this.focusOn++; 
		this.moveCameraAt += 5f; 
	}
	if(this.rotateCamera){
		switch(focusOn % 3){

			case 0:
				this.transform.LookAt(this.blueBall); 
				this.transform.RotateAround(this.blueBall,Vector3.up,rotationSpeed * Time.deltaTime);
				break; 
			case 1:
				this.transform.LookAt(this.redBall);
				this.transform.RotateAround(this.redBall,Vector3.up,rotationSpeed * Time.deltaTime);
				break; 
			case 2:
				this.transform.LookAt(this.yellowBall);
				this.transform.RotateAround(this.yellowBall,Vector3.up,rotationSpeed * Time.deltaTime);
				break; 

		}
		     
	}
	
    }
}
