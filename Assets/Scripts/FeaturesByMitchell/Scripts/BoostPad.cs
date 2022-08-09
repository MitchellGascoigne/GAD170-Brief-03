using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MitchellGascoigne
{
    public class BoostPad : MonoBehaviour
    // Copy from shellexplosion script
    {

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.gameObject.name);
        }
    }

}

// use events to make this happen (example in ShellExplosion.Boom script)
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