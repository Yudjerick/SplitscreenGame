using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private int playerCount = 2;
    [SerializeField] private GameObject playerRef;
    [SerializeField] private float distanceFromCenter = 1;
    public void Spawn()
    {
        GameSceneStarter starter = FindAnyObjectByType<GameSceneStarter>();
        if (starter != null) {
            playerCount = starter.PlayerCount;
        }
        for (int i = 0; i < playerCount; i++)
        {
            Instantiate(playerRef, Vector3.zero + Quaternion.Euler(0, 0, i * 360 / playerCount) * (Vector3.up * distanceFromCenter), Quaternion.identity);
        }
    }
}
