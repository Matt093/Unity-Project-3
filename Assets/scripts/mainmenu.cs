using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void opensetting()
    {
        settingsPanel.SetActive(true);
    }

    public void closesetting()
    {
        settingsPanel.SetActive(false); 
    }
    public void ExitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }





}
