using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class ColourChanger : MonoBehaviour
    {
        // This cube will CHANGE COLOURS when the "OnChangeColourEvent" event is announced
        // CHANGE COLOURS means to change the cube to a random colour
        private void OnEnable()
        {
            EventsManager.OnChangeColourEvent += ChangeColour;
        }

        private void OnDisable()
        {
            EventsManager.OnChangeColourEvent -= ChangeColour;
        }
        private void ChangeColour()
        {
            float redValue = Random.Range(0f, 1f);
            float greenValue = Random.Range(0f, 1f);
            float blueValue = Random.Range(0f, 1f);
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(redValue, greenValue, blueValue);
        }
    }
}
