using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CanvasSwitcher : MonoBehaviour
{
    public CanvasType newCanvasType;
    private CanvasManager canvasManager;
    private Button menuButton;
    // Start is called before the first frame update
    void Start()
    {
        menuButton = GetComponent<Button>();
        menuButton.onClick.AddListener(OnButtonClicked);
        canvasManager = CanvasManager.Instance;
    }

    // Update is called once per frame
    void OnButtonClicked()
    {
        canvasManager.SwitchCanvas(newCanvasType);
    }
}
