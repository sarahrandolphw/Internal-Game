using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public enum CanvasType
{
    MainMenu,
    InputMenu,
    GameUI,
    EndScreen
}

public class CanvasManager : MonoBehaviour
{
    List<CanvasController> canvasControllerList;
    CanvasController lastActiveCanvas;
    public static CanvasManager Instance { get; private set; }
    protected void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        canvasControllerList = GetComponentsInChildren<CanvasController>().ToList();
        canvasControllerList.ForEach(x => x.gameObject.SetActive(false)); // disable each game menu
        SwitchCanvas(CanvasType.MainMenu);

    }
    public void SwitchCanvas(CanvasType _type)
    {
        if(lastActiveCanvas != null)
        {
            lastActiveCanvas.gameObject.SetActive(false);
        }
        CanvasController newCanvas = canvasControllerList.Find(x => x.canvasType == _type);
        if(newCanvas != null)
        {
            newCanvas.gameObject.SetActive(true);
            lastActiveCanvas = newCanvas;
        } else {Debug.LogWarning("newCanvas is null");}
    }
}
