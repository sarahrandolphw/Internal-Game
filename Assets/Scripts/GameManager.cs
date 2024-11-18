// using System.Collections;
// using UnityEngine;
// using System.Collections.Generic;

// public class GameManager : MonoBehaviour
// {
//     public List<string> userInputs = new List<string>();

//     void Start()
//     {
//         LoadUserInputs();
//     }

//     void LoadUserInputs()
//     {
//         if (PlayerPrefs.HasKey("UserInputs"))
//         {
//             string inputString = PlayerPrefs.GetString("UserInputs");
//             userInputs = new List<string>(inputString.Split(',')); // Convert string back to list
//         }
//     }
// }