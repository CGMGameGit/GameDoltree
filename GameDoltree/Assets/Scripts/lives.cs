using UnityEngine;
using System.Collections;

public class lives : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (!scriptGameController.isGameOver)
        {
            if(other.tag == "Box")
            {
                scriptGameController.lives --;
            }
        }
    }
}
