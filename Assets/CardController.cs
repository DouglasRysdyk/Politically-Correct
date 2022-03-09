using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField]
    private GameObject cardPrefab; 

    private void Awake()
    {
        
    }
}

/*
- Controls when a card can spawn.  

- After choicePicked == true () a timer is set.  
  - choicePicked is stored on the card.  
- When that timer reaches 0 the card moves from above the screen (spawn @ (0-, 10, -1)) at the same speed as the crowd (-1)
- 
*/


