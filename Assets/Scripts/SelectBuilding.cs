using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class SelectBuilding : MonoBehaviour
{
    [SerializeField]
    Text buildingName;

    [SerializeField]
    Text buildingCost;

    [SerializeField]
    Image buildingIcon;
    
    [SerializeField]
    BuildData buildData;

    void Awake()
    {
        buildingName.text = buildData.BuildingName;
        buildingIcon.sprite = buildData.BuildingIcon;
        buildingCost.text = buildData.BuildingCost.ToString();
    }
}
