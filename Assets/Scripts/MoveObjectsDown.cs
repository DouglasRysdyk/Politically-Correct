using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectsDown : MonoBehaviour
{
    [SerializeField]
    private float movespeed = 1f; 
    
    void FixedUpdate()
    {
        transform.Translate(new Vector2 (0f, -1f) * movespeed * Time.deltaTime);
    }
}

//this.gameObject.transform.position = new Vector2(mousePosition.x, handleYAxis); 
//https://www.youtube.com/watch?v=-thhMXmTM7Q
//Really like this -- https://www.youtube.com/watch?v=pwRywYmajsY


