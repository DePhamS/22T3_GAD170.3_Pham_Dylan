using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class EventsManager : MonoBehaviour
    {
        // This will contain ALL OF OUR EVENTS

        // Event delegates have TWO PARTS
        // The DELEGATE which is the "type of event"
        // The EVENT itself, which gets "announced"

        // This is the TYPE of event we will call
        public delegate void VoidDelegate();

        // This is the EVENT itself
        public static VoidDelegate OnTeleportEvent;
        public static VoidDelegate OnChangeColourEvent;
        
        // The line below is used for our project 
        public static VoidDelegate OnButtonActivateEvent;
    }
}

