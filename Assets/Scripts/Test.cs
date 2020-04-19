using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    [SerializeField] int pieceCount;
    [SerializeField] Vector3 centerPos;
    [SerializeField] float radius;
    [SerializeField] GameObject prefab;

    private void Start() {
        InstantiateCircle();
    }

    void InstantiateCircle()
    {
        float angle = 360f / (float)pieceCount;
        for(int i = 0; i< pieceCount; i++)
        {
            Quaternion rotation = Quaternion.AngleAxis(i * angle, Vector3.up);
            Vector3 direction = rotation * Vector3.forward;

            Vector3 position = centerPos + (direction * radius);
            Instantiate(prefab,position, rotation);
        }
    }
}
