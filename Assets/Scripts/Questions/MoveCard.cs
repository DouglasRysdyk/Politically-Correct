using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCard : MonoBehaviour
{    
    private Vector2 mousePosition; 
    private bool isBeingHeld, choiceSelected, inPosition, rightChosen, leftChosen; 
    private float getCardDirection, handleYAxis; 

    //Get the Rigidbody2D component from the ElevatorGameObject 
    private void Awake() 
    {
        handleYAxis = this.gameObject.transform.position.y; 
    }

    private void Update() 
    {
      //If the object is active move it into position.
      // if (this.gameObject.activeSelf == true)
      // {
      //   if (inPosition == false)
      //   {
      //     //Check where the card is.  If the card is not in the spawn position move it there.  
      //     //Move the card from the spawn into position.
      //   }
      //   else {
      //     if (isBeingHeld == true) 
      //     {
      //       mousePosition = Input.mousePosition; 
      //       mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); 

      //       getCardDirection = mousePosition.x; 

      //       this.gameObject.transform.position = new Vector2(mousePosition.x, handleYAxis); 

      //       if (mousePosition.x <= -2.5 || mousePosition.x >= 2.5) 
      //       {
      //         if (getCardDirection > 0) 
      //         {
      //           rightChosen = true; 
      //         } 
      //         else if (getCardDirection < 0)
      //         {
      //           leftChosen = true; 
      //         }
      //       }
      //     }
      //   }
      // }
        if (isBeingHeld == true) 
        {
            mousePosition = Input.mousePosition; 
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); 

            getCardDirection = mousePosition.x; 

            this.gameObject.transform.position = new Vector2(mousePosition.x, handleYAxis); 

            if (mousePosition.x <= -5.5 || mousePosition.x >= 5.5) 
                choiceSelected = true; //NEED TO RESET CHOICESELECTED 
                                       //What does choiceSelected actually do?  
                                         //When false: play animations, add points, reset spawn timer maybe?  
                print("MADE IT"); 

            //Determine which way the handle is being pulled.  
            if (getCardDirection > 0) 
                print("RIGHT");
                rightChosen = true; 

            if (getCardDirection < 0) 
                print("LEFT");
                leftChosen = true; 
        }
    }

    private void FixedUpdated() 
    {
        //I want to learn how to use Fixedpdate properly.  It should make my work look a lot smoother & more optimized.  
    }
    
    private void OnMouseDown() 
    {
        if (Input.GetMouseButtonDown(0)) 
            isBeingHeld = true; 
    }
    
    private void OnMouseUp() {
        isBeingHeld = false;

        //Reset the card to the center of the screen.  
        if (!choiceSelected) 
            this.gameObject.transform.position = new Vector2(0, 0); 
    }
}

/*
Sources:
- For acceleration code foundation -- https://youtu.be/DVHcOS1E5OQ?t=159 
- For clicking and dragging code foundation -- https://www.youtube.com/watch?v=eUWmiV4jRgU 
- Capping max speed -- https://answers.unity.com/questions/265810/limiting-rigidbody-speed.html 
- UI drag and drop -- https://www.youtube.com/watch?v=BGr-7GZJNXg 

- Render multiple cameras -- https://www.youtube.com/watch?v=_kYiJtM8nMk 

- Awake VS Start: 
  - https://gamedevbeginner.com/start-vs-awake-in-unity/ 
  - https://stackoverflow.com/questions/34652036/awake-and-start 
- Awake is called even if an object in not enabled.  Start is called when an object is enabled.  

- C#'s switches don't like floats source -- https://social.msdn.microsoft.com/Forums/sqlserver/en-US/e3dc97a8-cd4b-4995-905e-0ab50060efe5/why-switch-case-cant-accept-floatingpoint-in-condition?forum=csharpgeneral 

Old Drag & Drop Notes:
- Going right always adds 
- Going left always subtracts 
- Zero is in the middle 
- How do you determine what direction the Handle is moving?  
- I think I understand how on a circle.  
  - It basically works on a line too, I just don’t know how I would determine the direction you’re going.
  - New number (new handle position) compared to old number (old handle position).  
  - > for above zero.  < for below zero.  
    - If newNumber > oldNumber then + force 
    - If newNumber < oldNumber then - force 

- oldPosition is recorded OnMouseDown
- oldPosition is checked against newPosition every frame 




- How to set the camera as the one being used 
- The mouse position is off because its drawing from the main camera, which this is not.  
*/



//Question Cards TODO
/*
- I need to show the player questions.  
  - Questions need to be made ahead of time.  
  - I want to optimize this as much as possible ahead of time.  

- I don't want to make a bunch of ScriptableObjects.  
  - I want to try using only one card whose text changes.  
  - A bunch of scriptable objects means more files.  They are not expensive, but I get the feeling it's unnecessary.    
- I want to reuse the same card over and over again.  
  - It will get its data from a CSV file.  
*/
