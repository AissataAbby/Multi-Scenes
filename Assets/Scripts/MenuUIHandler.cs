using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] ColorPicker ColorPicker;


public void NewColorSelected (Color color)
    {
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }
    // Start is called before the first frame update

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void SaveColorClicked()
    {
        MainManager.Instance.SaveColor();
    }

    public void LoadColorClicked()
    {
        MainManager.Instance.LoadColor();
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
        MainManager.Instance.SaveColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
