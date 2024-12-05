using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuButton : MonoBehaviour
{
    public void ToMenu()
    {
        GameSceneStarter gameSceneStarter = FindAnyObjectByType<GameSceneStarter>();
        if (gameSceneStarter != null)
        {
            Destroy(gameSceneStarter);
        }
        FindAnyObjectByType<NetworkManager>().StopClient();
        SceneManager.LoadScene("Menu");
    }
}
