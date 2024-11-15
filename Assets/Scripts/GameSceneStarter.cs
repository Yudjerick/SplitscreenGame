using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneStarter : MonoBehaviour
{
    public int PlayerCount {  get; set; }
    [SerializeField] private TMP_Dropdown dropdown;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        PlayerCount = dropdown.value + 2;
        SceneManager.LoadScene("SampleScene");
    }

    
}
