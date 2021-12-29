using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        playerName = inputField.text;
        DataManager.Instance.playerName = playerName;
        SceneManager.LoadScene(1);
    }

//     public void Exit()
//     {
//         MainManager.Instance.SaveColor();

// #if UNITY_EDITOR
//             EditorApplication.ExitPlaymode();
// #else
//         Application.Quit();
// #endif
//     }
}
