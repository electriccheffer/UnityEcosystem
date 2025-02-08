using UnityEngine;

public class Friction : MonoBehaviour
{
    public float frictionCoefficient;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	     
    }

    // Update is called once per frame
    void Update()
    {
    	 
    }


   public float getForce(){

	return frictionCoefficient; 
	
   }
}
