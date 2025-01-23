using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float rotationSpeed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	this.transform.RotateAround(new Vector3(-10f,10f,2f),Vector3.up,rotationSpeed * Time.deltaTime);     
    }
}
