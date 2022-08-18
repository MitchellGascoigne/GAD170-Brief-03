using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace MitchellGascoigne
{
    public class BoostPadEventsManager : MonoBehaviour
    {
        // For our Event system we need these things:
        // Announce event at particular times or when a particular collision occurs, etc...
        // We want to make sure our UI is LISTENING for the Event
        // When the Event is announced, we want to update our UI
        [SerializeField] private TextMeshProUGUI boostPadCounter;
        [SerializeField] private int boostPadCount = 0;
        private void OnEnable()
        {
            BoostPadCounter.OnBoostPadActivation += IncreaseBoostPadCount;
        }   
        private void OnDisable()
        {
            BoostPadCounter.OnBoostPadActivation -= IncreaseBoostPadCount;
        }
        // When the method is called, have the boost pad counter to add a value of "1"
        // Include the string ""Boost Pads Used:" followed by the amount of times it has been used
        private void IncreaseBoostPadCount()
        {
            boostPadCount++;
            boostPadCounter.text = "Boost Pads Used: " + boostPadCount;
        }
    }
}