using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [Range(1, 100)][SerializeField] private int NumberToSpawn = 20;
    [SerializeField] private GameObject BoxPrefab;
    [SerializeField] private GameObject SpherePrefab;
    [SerializeField] private GameObject CylinderPrefab;

    private Vector3 randomPosition;
    private void Start()
    {
        SpawnRandom();
    }

    public void SpawnRandom()
    {
        for (int i = 0; i < NumberToSpawn; i++)
        {
            randomPosition = Random.insideUnitSphere * 10;
            randomPosition.y = BoxPrefab.transform.position.y;
            Instantiate(BoxPrefab, randomPosition, Quaternion.identity);
            
            randomPosition = Random.insideUnitSphere * 10;
            randomPosition.y = BoxPrefab.transform.position.y;
            Instantiate(SpherePrefab, randomPosition, Quaternion.identity);
            
            randomPosition = Random.insideUnitSphere * 10;
            randomPosition.y = BoxPrefab.transform.position.y;
            Instantiate(CylinderPrefab, randomPosition, Quaternion.identity);
        }
    }
}
