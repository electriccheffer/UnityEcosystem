using UnityEngine;

public class SolarRotation : MonoBehaviour
{

    public float rotationSpeed; 	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	
	this.transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime); 
    
    }
}
