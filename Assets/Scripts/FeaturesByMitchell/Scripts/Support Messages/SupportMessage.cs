using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class SupportMessage : MonoBehaviour
    {
        [Header("A list of support messages")]
        private List<string> supportMessage = new List<string>(); // a list of all support messages for us to use.

        public void CreateSupport()
        {
            supportMessage.Add("We believe in you!");
            supportMessage.Add("Good Luck!");
            supportMessage.Add("You drive really well!");
        }
        public void SetSupportMessage()
        {
            // A method that Debug.logs one of the "Support Messages" at random to the console
            Debug.Log(supportMessage[Random.Range(0, supportMessage.Count)]);
        }
        // Also, you must subscribe(+=) and unsubscribe(-=) from the event OnEnable and OnDisable.It's like a pair; you have to do both.
         private void OnEnable()
        {
            ComplimentsEventsManager.OnClicked += SetSupportMessage;
        }
        private void OnDisable()
        {
            ComplimentsEventsManager.OnClicked -= SetSupportMessage;
        }
    }
}