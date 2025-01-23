using UnityEngine;

public class SolarRotation : MonoBehaviour
{
	
    private float xAngle = 1f;
    private float zAngle = 1f;
    private float yAngle = 1f;  
    private float rotationTimer = 1f; 
    private float elapsedTime = 0f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	elapsedTime += Time.deltaTime; 
	
	if(elapsedTime > rotationTimer){
		
		this.transform.Rotate(xAngle,yAngle,zAngle,Space.World); 
		this.rotationTimer += 1f; 
		
	}		
    
    }
}
