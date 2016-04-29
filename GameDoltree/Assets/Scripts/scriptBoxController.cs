using UnityEngine;
using System.Collections;

public class scriptBoxController : MonoBehaviour {

    public float moveSpeed;    
    public Material blackMaterial;
    
	void FixedUpdate () {
        if (!scriptGameController.isGameOver)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }	
	}
	
	void Update () {
        if (!scriptGameController.isGameOver)
        {
            Ray ray;
            RaycastHit hit;

            if (Input.GetMouseButtonDown(0) && transform.tag == "Box")
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if ( Physics.Raycast(ray, out hit, 30f))
                {
                    if(hit.transform == transform)
                    {
                        gameObject.tag = "Boxblack";
                        gameObject.GetComponent<Renderer>().material = blackMaterial;
                        scriptGameController.score ++;                        
                    }
                }
            }
        }	
	}
}
