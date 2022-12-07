using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace DylanPham
{
    public class ButtonActivator : MonoBehaviour
    {
        [SerializeField] private bool isPlayerCharacterNearby = false;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name == "Avatar")
            {
                isPlayerCharacterNearby = true;
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if(other.gameObject.name == "Avatar")
            {
                isPlayerCharacterNearby = false;
            }
        }
        // This script would be for the buttonActivator
        void Update()
        {
            // If the player presses E...
            if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNearby == true)
            {
                EventsManager.OnButtonActivateEvent?.Invoke();
                Debug.Log("Button Pressed!");
            }
        }
    }
}
