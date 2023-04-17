using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawmmanager : MonoBehaviour
{
    public GameObject obstaclesPrefabs;
    public Vector3 spawmPos;
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;
    private PlayerController playerController;
    void Start()
    {
        InvokeRepeating("SpawmObstacles", startDelay, repeatRate);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawmObstacles()
    {
        if (!playerController.isGameover)
            Instantiate<GameObject>(obstaclesPrefabs, spawmPos, obstaclesPrefabs.transform.rotation);
    }
}
