using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class CubeActivator : MonoBehaviour
    {
        // This script would be for the buttonActivator
        void Update()
        {
            // If the player presses E...
            if (Input.GetKeyDown(KeyCode.E))
            {
                // ...announce the events fo those tricky little cubes!
                EventsManager.OnChangeColourEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
            }
        }
    }
}
