using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MitchellGascoigne
{
    public class BoostPadCounter : MonoBehaviour
    {
        // Use events (Events enable a class or object to notify other classes or objects when something of interest occurs) 
        // Use the Event to to add data to a "Boost Pad Counter" when the Trigger Collider is activated 
        // Unity can save and load those values (all public fields are serialized by default) even though they are not public. 
        [SerializeField] private string playerTankTag = "player";
        // Creates a delegate that refers to the method for BoostPadActivationAction()
        public delegate void BoostPadActivationAction();
        public static event BoostPadActivationAction OnBoostPadActivation;

        // OnTriggerEnter is called when the Collider other enters the trigger (set the boostpad as the trigger)
        private void OnTriggerEnter(Collider other)
        { 
            if (other.CompareTag("Player")) 
            {
                // If the tank collides with the trigger zone, double its speed
                other.GetComponent<Tank>().tankMovement.speed = 24;
                //Debug.Log(other.gameObject.name);
                Debug.Log("You have used the Boost Pad");

                // Check if there is an absence of data or simply no data
                // If this is the case, call the OnBoostPadActivationMethod()
                if (OnBoostPadActivation != null)
                {
                    OnBoostPadActivation();
                }
                // Call the SpeedTime() method
                SpeedTime();

                // The Speedtime() method that returns an IEnumerator interface
                IEnumerator SpeedTime()
                {
                    // Have the boost pad effect wear off after 2 seconds
                    yield return new WaitForSeconds(1f);
                    // Have the speed set back to original speed of 12 after time
                    other.GetComponent<Tank>().tankMovement.speed = 12;
                }
                    // StopCoroutine takes one of three arguments which specify which coroutine is stopped:
                    // A string function naming the active coroutine
                    // The IEnumerator variable used earlier to create the coroutine.
                    // The Coroutine to stop the manually created Coroutine.
                if (other.gameObject.CompareTag("Player"))
                {
                    StopCoroutine(SpeedTime());
                    StartCoroutine(SpeedTime());
                }
            }
        }
    }
}