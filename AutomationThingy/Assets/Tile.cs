using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public enum TileType { Field, Forest, Stone, Water }
    public TileType tileType;

    void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            int randomInt = Random.Range(0, 4);
            switch(randomInt) {
                case 0:
                    SetTileType(TileType.Field);
                    break;
                case 1:
                    SetTileType(TileType.Forest);
                    break;
                case 2:
                    SetTileType(TileType.Stone);
                    break;
                case 3:
                    SetTileType(TileType.Water);
                    break;
            }
        }
    }

    void SetTileType(TileType type) {
        tileType = type;

        switch(tileType) {
            case TileType.Field:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case TileType.Forest:
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case TileType.Stone:
                GetComponent<Renderer>().material.color = Color.gray;
                break;
            case TileType.Water:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
        }
    }
}
