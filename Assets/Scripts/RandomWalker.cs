using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.GetKeyDown(KeyCode.Space))
	{
		takeStep();         
	}
    }

    private void takeStep()
    {
	int outcome = Random.Range(0,4);
	switch(outcome)
	{

		case 0:
			this.transform.position += new Vector3(0,0,1); 
			break; 
		case 1: 
			this.transform.position += new Vector3(1,0,0);
			break; 
		case 2: 
			this.transform.position += new Vector3(-1,0,0); 
			break; 
		case 3: 
			this.transform.position += new Vector3(0,0-1);
			break; 

	}

    }
}
