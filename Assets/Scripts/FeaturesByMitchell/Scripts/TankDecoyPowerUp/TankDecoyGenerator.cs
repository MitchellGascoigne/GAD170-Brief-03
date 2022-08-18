using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class TankDecoyGenerator : MonoBehaviour
    {
        private void OnEnable()
        {
           TriggerZone.OnTrigger += Teleport;

        }
        private void OnDisable()
        {
           TriggerZone.OnTrigger -= Teleport;
           //EventManager.OnClicked -= Teleport;
        }
        private void Teleport()
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }
}
