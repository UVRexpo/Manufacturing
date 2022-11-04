using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCs : MonoBehaviour
{
   [SerializeField] private Material myMaterial;
   private void onTriggerEnter(Collider other){
    if(other.CompareTag("Player")){
        myMaterial.color = Color.gr;
    }
   }
   private void onTriggerExit(Collider other){
    if(other.CompareTag("Player")){
        myMaterial.Color = Color.red;
    }
   }
}
