using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   
    private float xCoordinate = 0f; 
    private float zCoordinate = 0.5f; 
    private float yCoordinate = 0.3f; 
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
	if(Input.GetKeyDown(KeyCode.Space))
	{
		takeStep();         
	}
    }

    private float perlinStep(ref float coordinate)
    {
	float perlinValue = Mathf.PerlinNoise(coordinate,0); 
	coordinate += incrementAmount; 
	float newValue = Unity.Mathematics.math.remap(perlinValue,0f,1f,0f,10f);
	return newValue; 
    }

    private void takeStep()
    {
	float outcome = Random.Range(0f,1f);
	if(outcome < 0.1f)
	{
		this.transform.position += new Vector3(0,0,1); 
	}
	else if(outcome < 0.3f)
	{
		this.transform.position += new Vector3(1,0,0);
	}
	else if(outcome < 0.8f)
	{
		this.transform.position += new Vector3(-1,0,0); 
	}
	else
	{
		this.transform.position += new Vector3(0,0-1);
	}

    }
}
