using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public GameObject mainPanel, exitPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        // Application.LoadLevel("Scene");
        SceneManager.LoadScene(3);
    }
    public void Exit()
    {
        exitPanel.SetActive(true);
        mainPanel.SetActive(false);
    }
    public void No()
    {
        mainPanel.SetActive(true);
        exitPanel.SetActive(false);
    }
    public void Yes()
    {
        Application.Quit();
    }
    public void Rate()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.againto.callofspecialuscombatsecondarymission");

    }
    public void Privacypolicy()
    {
        Application.OpenURL("https://saifsomro999.wixsite.com/againto/callofspecialuscombatsecondarymissi");

    }
    public void Shop()
    {
        SceneManager.LoadScene(8);
    }
}
