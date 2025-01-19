using UnityEngine;

public class PerlinWalkerScript : MonoBehaviour
{
   
    private float xCoordinate = 3.0f; 
    private float zCoordinate = 2.3f; 
    private float yCoordinate = 0.0f;

    private float incrementAmount = 0.001f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
	float newX = perlinStep(ref xCoordinate); 	
	float newZ = perlinStep(ref zCoordinate); 
	float newY = perlinStep(ref yCoordinate);
	this.transform.position = new Vector3(newX,newY,newZ);
    }

    private float perlinStep(ref float coordinate)
    {
	float perlinValue = Mathf.PerlinNoise(coordinate,0); 
	coordinate += incrementAmount; 
	float newValue = Unity.Mathematics.math.remap(perlinValue,0f,1f,0f,10f);
	return newValue; 
    }

}
