using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BuildData", menuName = "Build Data", order = 51)]
public class BuildData : ScriptableObject
{
    [SerializeField]
    string buildingName;

    [SerializeField]
    string buildingDescription;

    [SerializeField]
    float buildingCost;

    [SerializeField]
    Sprite buildingIcon;

    [SerializeField]
    GameObject buildingPrefab;

    public string BuildingName { get => buildingName; set => buildingName = value; }
    public string BuildingDescription { get => buildingDescription; set => buildingDescription = value; }
    public float BuildingCost { get => buildingCost; set => buildingCost = value; }
    public Sprite BuildingIcon { get => buildingIcon; set => buildingIcon = value; }
    public GameObject BuildingPrefab { get => buildingPrefab; set => buildingPrefab = value; }
}
