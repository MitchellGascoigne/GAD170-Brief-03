using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MitchellGascoigne
{
    public class BoostPad : MonoBehaviour

    {

        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log(other.gameObject.name);
            if (other.CompareTag("Player")) 
            {
                // check if angle between tanks foward direction and boostpads foward direction if < 90, then run boost code (forward direction of transform)
                other.GetComponent<Tank>().tankMovement.speed = 24;
              
                
                
                
                // check if angle between tanks foward direction and boostpads foward direction if > 90 then reduce speed
                // https://docs.unity3d.com/ScriptReference/Vector3.Angle.html
                // kenny.nl (assets) 3d, racing kit

                // use events to call, trigger collided announce event have tank listening to event (may not bnefit in this scenrio) also implement it
                // decouples your classes dont need a direct link e.g all tanks explode now
                //Event will mean you dont need direct access to the other object
                // timer gameover event over tank listens to game over
                // shell explosion (uses event that evokes damage) follow that as a template implement that for a barrell fuel example. to show understand events 

                //usetime script from week 11 activities
            }
        }

    }
}

    
//Use events to make this happen (example in ShellExplosion.Boom script)
//When something collides with the boost pad we run this method
//Check if a tank has collided with the boost pad

//Check what angle the tank collided at
//If angle is between 0 and 90 degrees increase speed to 24
//Else decrease tanks speed to 6
//After 2 seconds, reset the tanks speed to base set of 12



//private void OnCollisionEnter(Collision collision)
//{
//    BoostPadCollision();
//}
//private void BoostPadCollision()