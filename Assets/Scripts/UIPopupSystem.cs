using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DylanPham
{
    public class UIPopupSystem : MonoBehaviour
    {
        [SerializeField] private GameObject popUp;

        private void Start()
        {
            popUp.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name == "Avatar")
            {
                popUp.SetActive(true);
                Debug.Log("POPUP!");
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "Avatar")
            {
                popUp.SetActive(false);
            }
        }
    }
}
