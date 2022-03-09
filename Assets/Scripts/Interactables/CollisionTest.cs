using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private float xPosition = 0; 

    private void Update()
    {
        //Only need to run when there is less than 2 interactables on the screen.  Do later.  
        xPosition = Random.Range(-1.9f, 1.9f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Obstacle")
        {
            other.transform.position = new Vector2(xPosition, 10);
            Debug.Log("We hit an obstacle!");
        }

        if (other.name == "Pick Up")
        {
            other.transform.position = new Vector2(xPosition, 10);
            Debug.Log("We hit an pick up!");
        }
    }
}


