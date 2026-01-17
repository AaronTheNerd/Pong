using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class pausemenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void OnTriggerEnter()
    {
        //Canvas.SetActive(true);
    } 
    public void OnTriggerExit()
    {
        //canvasTrigger.SetActive(false);
    }
}
