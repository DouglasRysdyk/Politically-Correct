using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetInteractablePosition : MonoBehaviour
{
    private float xPosition = 0; 

    private void Update()
    {
        //Only need to run when there is less than 2 interactables on the screen.  Do later.  
        xPosition = Random.Range(-1.9f, 1.9f);

        if (this.gameObject.transform.position.y <= -6)
        {
            this.gameObject.transform.position = new Vector2(xPosition, 10);
        }
    }
}


