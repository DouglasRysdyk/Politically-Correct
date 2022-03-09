using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCrowdPosition : MonoBehaviour
{
    private void Update() 
    {
        if(this.gameObject.transform.position.y <= -10.4f)
        {
            this.gameObject.transform.position = new Vector2(0, 10.75f);
        }
    }
}


