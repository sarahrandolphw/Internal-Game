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
    public void ButtonDown()
    {
        userTasks.Add(input.text);
        input.text = "";
        Debug.Log(String.Join(", ", userTasks));
        output.text = userTasks[userTasks.Count - 1];
    }
    
}
