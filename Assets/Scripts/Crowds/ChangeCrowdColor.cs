using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCrowdColor : MonoBehaviour
{
    private Renderer rend; 

    private Color colorToTurnTo = Color.white; 

    private void Start()
    {
        rend = GetComponent<Renderer>();

        rend.material.color = colorToTurnTo; 
    }
}

//Source -- https://www.youtube.com/watch?v=J66UkLJHzCY 


