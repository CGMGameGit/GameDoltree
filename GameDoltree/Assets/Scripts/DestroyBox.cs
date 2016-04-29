using UnityEngine;
using System.Collections;

public class DestroyBox : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (!scriptGameController.isGameOver)
        {
            if(other.tag == "check2")
            {
                Destroy(gameObject);
            }
        }
    }
}
