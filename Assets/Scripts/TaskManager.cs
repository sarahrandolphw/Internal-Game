using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;


public class TaskManager : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField input;
    private List<string> userTasks = new List<string>();
    [SerializeField]
    public List<string> defaultTasks = new List<string> {
    "Pull up a picture of your favorite celebrity",
    "Wink and smile at someone",
    "New task blah"
    };
    // public GameManager gameManager;

    public void ButtonDown()
    {
        userTasks.Add(input.text);
        input.text = "";
        Debug.Log(String.Join(", ", userTasks));
        output.text = userTasks[userTasks.Count - 1];
        string inputString = String.Join(",", userTasks); 
        PlayerPrefs.SetString("user", inputString);
        PlayerPrefs.Save();
        // gameManager.SaveTasks(userTasks);
    }
    // void Start()
    // {
    //     if (gameManager == null)
    //     {
    //         gameManager = GameManager.Instance;
    //     }
    //     userTasks = gameManager.LoadTasks();
    // }
}
