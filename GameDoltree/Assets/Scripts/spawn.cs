using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public GameObject BoxPrefab;
	public GameObject[] aaa;
	GameObject xxx;

	private int positionobject;

	void Start()
	{
		InvokeRepeating ("spawnBox", 1f, 3f);
	}

	void Update ()
	{

	}

	void spawnBox ()
	{
		positionobject = (int)Random.Range (0, 4);

		xxx = Instantiate(BoxPrefab,aaa[positionobject].transform.position , Quaternion.identity) as GameObject;

	}
}
