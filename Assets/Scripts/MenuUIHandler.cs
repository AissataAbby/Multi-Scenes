using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;
    public void NewColorSelected (Color color)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        ColorPicker.Init();
        ColorPicker.onColorChanged += NewColorSelected;
    }
    void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
