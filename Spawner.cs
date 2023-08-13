using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    Vector2 xRange;
    [SerializeField]
    Vector2 yRange;
    [SerializeField]
    GameObject bombPrefab;
    [SerializeField]
    Vector2 timeBetweenSpawns;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float x = Random.Range(xRange.x, xRange.y);
            float y = Random.Range(yRange.x, yRange.y);
            GameObject bomb= Instantiate(bombPrefab, new Vector3(x, y, 0), Quaternion.identity);
            bomb.transform.parent = gameObject.transform;
            float t = Random.Range(timeBetweenSpawns.x, timeBetweenSpawns.y);
            yield return new WaitForSeconds(t);
        }
    }
}
