using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
 //if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
//else
        Application.Quit(); 
        // original code to quit Unity player
//endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
