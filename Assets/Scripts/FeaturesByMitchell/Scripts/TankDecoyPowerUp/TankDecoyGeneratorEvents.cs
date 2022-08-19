using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class TankDecoyGeneratorEvents : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        // This function is called just after the object is enabled.
        private void OnEnable()
        {
            Debug.Log("Player Number is: " + GetComponent<Tank>().playerNumber);
            if (GetComponent<Tank>().playerNumber == PlayerNumber.One)
            {
                TriggerZone.OnTriggerPlayer01 += Clone;
            }
            if (GetComponent<Tank>().playerNumber == PlayerNumber.Two)
            {
                TriggerZone.OnTriggerPlayer02 += Clone;
            }
        }
        // This function is called when the behaviour becomes disabled
        private void OnDisable()
        {
            if (GetComponent<Tank>().playerNumber == PlayerNumber.One)
            {

                TriggerZone.OnTriggerPlayer01 -= Clone;
            }
            if (GetComponent<Tank>().playerNumber == PlayerNumber.Two)
            {
                TriggerZone.OnTriggerPlayer02 -= Clone;
            }
        }
        // A clone method to clone in the "decoy" tank for each player at an assigned transform position
        private void Clone()
        {
           transform.position = new Vector3(3, 1, 10);
           GameObject clone = Instantiate(prefab, new Vector3(3, 1, 10), transform.rotation);
            clone.name = "decoy";
            
        }
    }
}
