using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager i;

    public int wood;

    void Awake() {
        i = this;
    }
}
