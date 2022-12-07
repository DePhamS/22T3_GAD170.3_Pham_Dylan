using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class Teleporter : MonoBehaviour
    {
        // This cube will TELEPORT when the "OnTeleportEvent" event is announced
        // TELEPORT means to will move the cube to a random position on the Y axis

        private void OnEnable()
        {
            EventsManager.OnTeleportEvent += Teleport;
        }

        private void OnDisable()
        {
            EventsManager.OnTeleportEvent -= Teleport;
        }

        private void Teleport()
        {
            transform.position = new Vector3(2, Random.Range(0.5f, 4f), 0);
        }
    }
}
