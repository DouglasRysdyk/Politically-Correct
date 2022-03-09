using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInteractableDown : MonoBehaviour
{
    [SerializeField]
    private float movespeed = 1f;         

    private void Update()
    {
        //Don't need to always run.  Do later.  
        //Basically only run once after it's spawn.  Do not change as it translates.  
//        movespeed = Random.Range(.5f, 2f);
    }
    
    void FixedUpdate()
    {
        transform.Translate(new Vector2 (0f, -1f) * movespeed * Time.deltaTime);
    }
}

//this.gameObject.transform.position = new Vector2(mousePosition.x, handleYAxis); 
//https://www.youtube.com/watch?v=-thhMXmTM7Q
//Really like this -- https://www.youtube.com/watch?v=pwRywYmajsY


