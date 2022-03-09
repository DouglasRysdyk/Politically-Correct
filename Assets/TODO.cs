using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TODO : MonoBehaviour {}
//Notes 
/*
- I think I should start on the GameManager.  
  - Look at political compass stuff.  
- Continue designing the actual game and meta game.  
- How do I make my randomness better?  

- Make a progress bar.  
  - Make the progress bar work properly.  
- Polish the cards.
  - Optimization: 
    - Right now the card is covered by something invisible, so high alpha.  Is this okay from an optimization stand point?  
  - Movement: 
    - Snap card back to the center of the screen.  
    - Instead of making the card follow the mouse exactly, add some resistance so the player has more time to think about their choice.  Make it feel like flicking a card.  
      - I don't know how to do this.  
    - Make the cards come from the top of the screen?  
      - Maybe start the card above the screen and disable the object.  Then if it's time to spawn one enable the object and transform it down to the center of the screen.  
      - When a choice is chosen take control away from the player and transform the card off screen.  Disable it, and move it back to the top of the screen.  
  - How do I add an interval for spawning cards?  
- How do I do the procedural text for the cards?  
- How do I spawn and move the card on to the screen?  
- How do I make the crowd turn colors progrmamatically?  
- How do I change the effects of the picks and obstacles?  
  - Start with a string that says what happened to the player.  Do more later.  
*/

//Sources 
/*
- Change camera for mobile portrait mode: 
  - https://www.youtube.com/watch?v=Yt3Gvi9ZzbU -- Used 
  - https://www.youtube.com/watch?v=Y-OZOHwJc1w 
- Lorem Ipsum Generator -- https://loremipsum.io/generator/?n=1&t=p 
- World space UI -- https://www.youtube.com/watch?v=Zwgj3mwOVlg  
  - Do I need to raycast anything here?  I can't imagine why I would.  
  - Also follow this for the progress bar.  
*/

//Resources:
/*
- Display text on screen in Unity -- https://www.youtube.com/watch?v=LuAAzNDhVko 
- Progress bar -- https://www.youtube.com/watch?v=J1ng1zA3-Pk 
- Excel: 
  - https://www.youtube.com/watch?v=tI9NEm02EuE 
  - https://www.youtube.com/watch?v=1EdLTF43d70 
- Instantiate stuff -- https://www.youtube.com/watch?v=E7gmylDS1C4 
- Object pooling -- https://www.youtube.com/watch?v=tdSmKaJvCoA 
*/


