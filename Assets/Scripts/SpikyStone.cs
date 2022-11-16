using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class SpikyStone : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("You touch the spiky stone");
        }
    }
}
