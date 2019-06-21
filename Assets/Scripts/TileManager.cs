using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManager : MonoBehaviour
{
    
    Tilemap tilemap;

    void Awake() {
        tilemap = GetComponent<Tilemap>();
    }

    void OnMouseOver() {
        
    }
}
