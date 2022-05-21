using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Scene : MonoBehaviour
{
    public static int sceneCounter;
    public Text cashDisplay;
    public Text coinDisPlay;
    public GameObject cashObject;
    public GameObject coinObject;
    public GameObject informationPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        coinDisPlay.text = "" + PlayerPrefs.GetInt("Coins");
        cashDisplay.text = "" + PlayerPrefs.GetInt("Cash");
    }
    void Update()
    {
        
    }

    public void LevelSelection1()
    {
        sceneCounter = 1;
        SceneManager.LoadScene(4);

    }
    public void LevelSelection2()
    {
        if (PlayerPrefs.GetInt("lv5") == 1)
        {
            sceneCounter = 2;
            SceneManager.LoadScene(5);
        }
        else
        {
            informationPanel.SetActive(true);
            StartCoroutine(InformationPanelFunction());
        }

    }
    IEnumerator InformationPanelFunction()
    {
        yield return new WaitForSeconds(2f);
        informationPanel.SetActive(false);
    }
    public void LevelSelection3()
    {
        if (PlayerPrefs.GetInt("lv10") == 1)
        {
            sceneCounter = 3;
            SceneManager.LoadScene(6);
        }
        else
        {
            informationPanel.SetActive(true);
            StartCoroutine(InformationPanelFunction());
        }

    }
    public void BackScene()
    {
        SceneManager.LoadScene(2);
    }
    public void Store()
    {
        SceneManager.LoadScene(8);
    }
    public void Rate()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.againto.callofspecialuscombatsecondarymission");

    }
    public void Privacypolicy()
    {
        Application.OpenURL("https://saifsomro999.wixsite.com/againto/callofspecialuscombatsecondarymissi");

    }
}
