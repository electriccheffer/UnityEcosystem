using UnityEngine;

public class PerlinBoxCreator : MonoBehaviour
{

    public GameObject newSquare; 
    public Material color; 
    public float nextSpawn; 
    public float elapsedTime; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	this.nextSpawn = 5f;         
    	this.elapsedTime = 0f; 
    }

    // Update is called once per frame
    void Update()
    {
	this.elapsedTime += Time.deltaTime; 
	
	if(this.elapsedTime >= this.nextSpawn){
	
		newSquare = Instantiate(newSquare,this.transform.position,this.transform.rotation); 
		Renderer newSquareColor = newSquare.GetComponent<Renderer>(); 
		newSquareColor.material = color; 
		this.nextSpawn += 5f; 
	}        
	
    }
}
