using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class EventManager : MonoBehaviour
    {
        [Header("A list of spectator support messages")]
        private List<string> supportMessage = new List<string>(); // a list of all possible first names for us to use.

        public void CreateSupport()
        {
            supportMessage.Add("We believe in you!");
            supportMessage.Add("Good Luck!");
            supportMessage.Add("You drive really well!");
        }
        public void SetSupportMessage()
        {
            // So here rather than each character being called Blanky Blank Blank,
            // we probably want it to be a random first,last and nickname


            Debug.Log(supportMessage[Random.Range(0, supportMessage.Count)]);

        }

        // Set the "Click Action" for the button
        public delegate void ClickAction();     
        public static event ClickAction OnClicked;

        // Set "Click" button screen positioing in retrospect to the screens aspect ratio
        private void OnGUI()
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, 450, 100, 30), "Click"))
            {
                if (OnClicked != null)
                {
                    OnClicked();
                }

            }

        }
        private void OnEnable()
        {
            EventManager.OnClicked -= SetSupportMessage();


        }
        private void OnDisable()
        {

          //  EventManager.OnClicked 
        }
    }
}