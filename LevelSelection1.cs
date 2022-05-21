using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelection1 : MonoBehaviour
{
    public static int levelCounter;
    public GameObject levelPanel, loadingPanel;
    public GameObject unlock2, unlock3, unlock4, unlock5;

    public Text cashDisplay;
    public Text coinDisPlay;
    public GameObject cashObject;
    public GameObject coinObject;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        levelPanel.SetActive(true);
        loadingPanel.SetActive(false);
        coinDisPlay.text = "" + PlayerPrefs.GetInt("Coins");
        cashDisplay.text = "" + PlayerPrefs.GetInt("Cash");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("lv1") == 1)
        {
            unlock2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lv2") == 1)
        {
            unlock3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lv3") == 1)
        {
            unlock4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("lv4") == 1)
        {
            unlock5.SetActive(false);
        }
    }
    public void Level1()
    {
        levelCounter = 1;
        loadingPanel.SetActive(true);
        levelPanel.SetActive(false);
        StartCoroutine(GamePlayStarts());
    }
    public void Level2()
    {
        levelCounter = 2;
        loadingPanel.SetActive(true);
        levelPanel.SetActive(false);
        StartCoroutine(GamePlayStarts());
    }
    public void Level3()
    {
        levelCounter = 3;
        loadingPanel.SetActive(true);
        levelPanel.SetActive(false);
        StartCoroutine(GamePlayStarts());
    }
    public void Level4()
    {
        levelCounter = 4;
        loadingPanel.SetActive(true);
        levelPanel.SetActive(false);
        StartCoroutine(GamePlayStarts());
    }
    public void Level5()
    {
        levelCounter = 5;
        loadingPanel.SetActive(true);
        levelPanel.SetActive(false);
        StartCoroutine(GamePlayStarts());
    }
    IEnumerator GamePlayStarts()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(7);
    }
    public void BackScene()
    {
        //Application.LoadLevel("Scene");
        SceneManager.LoadScene(3);
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
