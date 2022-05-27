using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMovementFactory : MonoBehaviour
{
    public static GameObject gameObjectReference;
    void Start() => gameObjectReference = gameObject;
    public static MonoBehaviour Create<T>() where T : MonoBehaviour
    {
        var c = gameObjectReference.GetComponent<T>();
        return c == null ? gameObjectReference.AddComponent<T>() : c;
    }
}
