using Mono.CompilerServices.SymbolWriter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DylanPham
{
    public class TransientBlock : MonoBehaviour
    {
        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

        private void TurnTangible()
        {
            // Detecting if the box collider is on
            if(block.GetComponent<BoxCollider>().enabled == true)
            {
                // If so then it turns it off
                block.GetComponent<BoxCollider>().enabled = false;

                // Changes materials
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;
            }
        }
        private void TurnIntangible()
        {
            // Detecting if the box collider is off
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                // If so then it turns it on
                block.GetComponent<BoxCollider>().enabled = true;

                // Changes materials
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;
            }
        }
    }
}
