using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DylanPham
{
    public class SpikyStone : MonoBehaviour
    {
        public int Respawn;
        private void OnCollisionEnter(Collision collision)
        {
            SceneManager.LoadScene(Respawn);
        }
    }
}