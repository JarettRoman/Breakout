using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuUIHandler : MonoBehaviour
{
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
