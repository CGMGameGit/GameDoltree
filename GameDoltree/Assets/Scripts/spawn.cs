using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public GameObject BoxPrefab;
	public GameObject[] aaa;
	GameObject xxx;

	private int positionobject;

	void Start()
	{
        InvokeRepeating("spawnBox", 1f, 0.75f);	
	}

	void Update ()
	{
        if (scriptGameController.isGameOver)
        {
            CancelInvoke();
        }
    }

	void spawnBox ()
	{
		positionobject = (int)Random.Range (0, 4);

		xxx = Instantiate(BoxPrefab,aaa[positionobject].transform.position , Quaternion.identity) as GameObject;

	}
}
