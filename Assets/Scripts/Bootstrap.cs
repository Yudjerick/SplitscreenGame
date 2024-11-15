using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    void Start()
    {
        FindAnyObjectByType<PlayerSpawner>().Spawn();
        FindAnyObjectByType<CamerasParametersSetter>().SetCameras();
        FindAnyObjectByType<InputSubscribing>().SubcribeToInput();
        FindAnyObjectByType<ActionRebinder>().RebindPlayerInputKeys();
        FindAnyObjectByType<VictoryManager>().RegisterPlayersHp();
    }
}
