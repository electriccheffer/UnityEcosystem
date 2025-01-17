using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   
    private float xCoordinate = 0f; 
    private float incrementAmount = 0.001f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	

	perlinStep(); 	
	if(Input.GetKeyDown(KeyCode.Space))
	{
		takeStep();         
	}
    }

    private void perlinStep()
    {
	float perlinValue = Mathf.PerlinNoise(xCoordinate,0); 
	xCoordinate += incrementAmount; 
	float newX = Unity.Mathematics.math.remap(perlinValue,0f,1f,0f,10f);
	this.transform.position = new Vector3(newX,transform.position.y,transform.position.z);
	this.transform.position = new Vector3(newX,transform.position.y,transform.position.z);

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
