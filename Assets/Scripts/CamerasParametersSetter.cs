using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CamerasParametersSetter : MonoBehaviour
{
    [SerializeField] private List<Camera> cameras;
    private List<Player> moveComponents;

    public void SetCameras()
    {
        moveComponents = FindObjectsOfType<Player>().ToList();
        cameras = FindObjectsOfType<Camera>().ToList();
        switch (moveComponents.Count)
        {
            case 1:
                cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
                break;
            case 2:
                cameras[0].rect = new Rect(0f, 0f, 0.5f, 1f);
                cameras[1].rect = new Rect(0.5f, 0f, 0.5f, 1f);
                break;
            case 3:
                cameras[0].rect = new Rect(0f, 0.25f, 0.5f, 0.5f);
                cameras[1].rect = new Rect(0.5f, 0f, 0.5f, 0.5f);
                cameras[2].rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
                break;
            case 4:
                cameras[0].rect = new Rect(0f, 0f, 0.5f, 0.5f);
                cameras[1].rect = new Rect(0f, 0.5f, 0.5f, 0.5f);
                cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 0.5f);
                cameras[3].rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
                break;

        }
    }
}
