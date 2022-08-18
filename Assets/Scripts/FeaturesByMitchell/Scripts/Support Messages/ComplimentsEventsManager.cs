using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class ComplimentsEventsManager : MonoBehaviour
    {
        // Set the "Click Action" for the button
        public delegate void ClickAction();
        public static event ClickAction OnClicked;

        // Set "Click" button screen positioning in retrospect to the screens aspect ratio
        private void OnGUI()
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, 450, 200, 30), "Support Message"))
            {
                if (OnClicked != null)
                {
                    OnClicked();
                }
            }
        }
    }
}
