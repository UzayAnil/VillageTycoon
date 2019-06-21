using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSlotScript : MonoBehaviour
{
    public GameObject BuildMenu;
    void OnMouseUp() {
        if (BuildMenu != null){
            CharacterMovement charMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
            charMovement.enabled = false;      
            BuildMenu.SetActive(true);
            BuildMenu.GetComponent<BuildMenu>().buildingPlace = this.gameObject;
        }
    }
}
