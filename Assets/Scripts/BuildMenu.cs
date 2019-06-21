using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class BuildMenu : MonoBehaviour
{
    [SerializeField]
    Text buildingName;

    [SerializeField]
    Text buildingDescription;

    [SerializeField]
    Text buildingCost;

    [SerializeField]
    Image buildingIcon;

    [SerializeField]
    GameObject buidingPrefab;

    GameObject[] selectBuildings;
    public GameObject buildingPlace;
    
    [SerializeField]
    GameObject playerManager;

    [SerializeField]
    Button buildButton;

    [SerializeField]
    BuildData defaultData;

    [SerializeField]
    Text bank;

    void OnEnable() {
        UpdateBuildMenuInfo(defaultData);    
    }
    void VerifyFunds() {
        bank.text = playerManager.GetComponent<PlayerManagerScript>().bank.ToString();
        if(playerManager.GetComponent<PlayerManagerScript>().bank >= int.Parse(buildingCost.text)){
            buildButton.interactable = true;
        }
        else
        {
            buildButton.interactable = false;
        }
    }
    public void UpdateBuildMenuInfo(BuildData buildData)
    {
        buildingName.text = buildData.BuildingName;
        buildingDescription.text = buildData.BuildingDescription;
        buildingIcon.sprite = buildData.BuildingIcon;
        buildingCost.text = buildData.BuildingCost.ToString();
        buidingPrefab = buildData.BuildingPrefab;
        VerifyFunds();
    }

    public void CallEngineer(){
        playerManager.GetComponent<PlayerManagerScript>().bank -= int.Parse(buildingCost.text);
        GetComponent<Engineer>().Build(buidingPrefab, buildingPlace);
        buildingPlace.GetComponent<BuildSlotScript>().BuildMenu = null;
        VerifyFunds();
        CloseBuildingMenu();
    }

    public void CloseBuildingMenu()
    {
        this.gameObject.SetActive(false);
        CharacterMovement charMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement>();
        charMovement.enabled = true;
    }
}
