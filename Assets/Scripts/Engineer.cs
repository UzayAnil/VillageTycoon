using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : MonoBehaviour
{
    public void Build(GameObject buildingPrefab, GameObject buildingSlot){
        var newBuilding = (GameObject)Instantiate(
            buildingPrefab,
            buildingSlot.transform.position,
            buildingSlot.transform.rotation
        );
    }
}
