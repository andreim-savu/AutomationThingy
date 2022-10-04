using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] int height;
    [SerializeField] int width;
    [SerializeField] string seed;

    [SerializeField] GameObject tileObject;
    void Start()
    {
        GenerateGrid();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateGrid() {
        Vector3 initialPoint = new Vector3(-(width - 1)/2.0f, 0, -(height - 1)/2.0f);
        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                Instantiate(tileObject, initialPoint + new Vector3(j, 0, i), Quaternion.identity, transform);
            }
        }
    }
}
