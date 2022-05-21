using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;
public class Gameplay : MonoBehaviour
{
    public GameObject helpText, helpTextShadow, ammoText, ammoShadow;
    public GameObject level1, level2, level3, level4, level5;
    public GameObject level6, level7, level8, level9, level10;
    public GameObject level11, level12, level13, level14, level15;
    public GameObject infoPanel;
    public GameObject completePanel, failPanel, pausePanel;
    public GameObject uiCanvas,cf2Panel;
    public GameObject playerta;
    public GameObject m1911, shotGun, mp5, m4, ak47, sniper;
    public GameObject cashObject;
    public GameObject coinObject;
    public GameObject enemyObject;
    GameObject playerTag;
  public  GameObject[] enemyTag;
    int enemyLength;
    FPSPlayer fpsPlayerScript;
    WeaponBehavior weaponBehaviourScript;
    public Text cashDisplay;
    public Text coinDisPlay;
    public Text enemyDisplay;
    public static int cashCounter, tempCash;
    public static int coinCounter, tempCoin;
    bool levelCheck;
    bool failCheck = false;
    bool levelComplCheck=false;


    void Start()
    {
        Time.timeScale = 1;

        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        helpText.SetActive(false);
        helpTextShadow.SetActive(false);
        ammoText.SetActive(false);
        ammoShadow.SetActive(false);
        infoPanel.SetActive(true);
        uiCanvas.SetActive(true);
        cf2Panel.SetActive(true);
        completePanel.SetActive(false);
        failPanel.SetActive(false);
        pausePanel.SetActive(false);
        cashObject.SetActive(true);
        coinObject.SetActive(true);
        enemyObject.SetActive(true);
        failCheck = false;
        levelComplCheck = false;
        levelCheck = false;

        playerTag = GameObject.FindGameObjectWithTag("Player");
        enemyTag = GameObject.FindGameObjectsWithTag("Flesh");

        StartCoroutine(InstructionPanel());

        m1911.GetComponent<WeaponBehavior>().haveWeapon=true;
        if (PlayerPrefs.GetInt("M4") == 1)
        {
            m4.GetComponent<WeaponBehavior>().haveWeapon = true;
        }
        if (PlayerPrefs.GetInt("MP5") == 1)
        {
            mp5.GetComponent<WeaponBehavior>().haveWeapon = true;
        }
        if (PlayerPrefs.GetInt("ShotGun") == 1)
        {
            shotGun.GetComponent<WeaponBehavior>().haveWeapon = true;
        }
        if (PlayerPrefs.GetInt("Ak47") == 1)
        {
            ak47.GetComponent<WeaponBehavior>().haveWeapon = true;
        }
        if (PlayerPrefs.GetInt("Sniper") == 1)
        {
            sniper.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 1 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-37.716f, 38.612f, 34.69f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level1.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "1";
        }
        if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 2 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-66.88f, 38.43f, 7.85f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 180f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level2.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "2";
        }
        if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 3 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-82.17f, 38.54f, -12.52804f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level3.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "3";
        }
        if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 4 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-82.17f, 38.54f, -12.52804f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level4.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "4";
        }
        if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 5 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-26.04907f, 46.23f, -63.18025f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level5.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "5";
        }

        //Scene 2 Levels
        if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 1 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-19.53785f, 40.56f, -45.29f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = -90f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level6.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "3";
        }
        if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 2 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-31.45272f, 46.1581f, -75.39156f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 90f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level7.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "4";
        }
        if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 3 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-37.34705f, 46.12f, -92.40372f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level8.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "4";
        }
        if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 4 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-20.95f, 46.23f, -65.9f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 180f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level9.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "6";
        }
        if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 5 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-26.04907f, 46.23f, -63.18025f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level10.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "7";
        }
        //Scene 3
        if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 1 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(7.12f, 46.14f, -76.63574f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 90f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level11.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "3";
        }
        if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 2 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-37.34705f, 46.12f, -92.40372f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level12.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "5";
        }
        if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 3 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-1.214918f, 46.23f, -75.39156f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 90f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level13.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "6";
        }
        if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 4 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-82.17f, 38.54f, -12.52804f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 180f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level14.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "8";
        }
        if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 5 && levelCheck == false)
        {
            playerta.transform.position = new Vector3(-82.17f, 38.54f, -12.52804f);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y = 0f;
            playerta.transform.rotation = Quaternion.Euler(temp);
            level15.SetActive(true);
            levelCheck = true;
            enemyDisplay.text = "10";
        }


        coinDisPlay.text = ""+PlayerPrefs.GetInt("Coins");
        cashDisplay.text = "" + PlayerPrefs.GetInt("Cash");
        enemyLength = enemyTag.Length;
    }

    void Update()
    {
        LevelOpen1();
        GameCompleted();
        GameFailed();
    }
    IEnumerator InstructionPanel()
    {
        yield return new WaitForSeconds(4);
        infoPanel.SetActive(false);
    }
    public void LevelOpen1() {
       
        enemyTag = GameObject.FindGameObjectsWithTag("Flesh");
        playerTag = GameObject.FindGameObjectWithTag("Player");
    }

    public void GameCompleted()
    {
        if (LevelCompleteCollider.colliderCheck   && levelComplCheck==false)
        {
            levelComplCheck = true;
            print("here");
            completePanel.SetActive(true);
            uiCanvas.SetActive(false);
            cashObject.SetActive(false);
            coinObject.SetActive(false);
            cashCounter = int.Parse(cashDisplay.text);
            cashCounter = cashCounter + 5;
            PlayerPrefs.SetInt("Cash", cashCounter);
            PlayerPrefs.Save();
            coinCounter = int.Parse(coinDisPlay.text);
            coinCounter = coinCounter + 100;
            PlayerPrefs.SetInt("Coins", coinCounter);
            PlayerPrefs.Save();
            Time.timeScale = 0;
            LevelCompleteCollider.colliderCheck = false;
        }

        if (levelComplCheck == true)
        {
            levelComplCheck = false;
            if (Scene.sceneCounter==1 && LevelSelection1.levelCounter == 1)
            {
                PlayerPrefs.SetInt("lv1", 1);
            }
            if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 2)
            {
                PlayerPrefs.SetInt("lv2", 1);
            }
            if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 3)
            {
                PlayerPrefs.SetInt("lv3", 1);
            }
            if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 4)
            {
                PlayerPrefs.SetInt("lv4", 1);
            }
            if (Scene.sceneCounter == 1 && LevelSelection1.levelCounter == 5)
            {
                PlayerPrefs.SetInt("lv5", 1);
            }
            if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 1)
            {
                PlayerPrefs.SetInt("lv6", 1);
            }
            if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 2)
            {
                PlayerPrefs.SetInt("lv7", 1);
            }
            if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 3)
            {
                PlayerPrefs.SetInt("lv8", 1);
            }
            if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 4)
            {
                PlayerPrefs.SetInt("lv9", 1);
            }
            if (Scene.sceneCounter == 2 && LevelSelection2.levelCounter == 5)
            {
                PlayerPrefs.SetInt("lv10", 1);
            }
            if(Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 1)
            {
                PlayerPrefs.SetInt("lv11", 1);
            }
            if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 2)
            {
                PlayerPrefs.SetInt("lv12", 1);
            }
            if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 3)
            {
                PlayerPrefs.SetInt("lv13", 1);
            }
            if (Scene.sceneCounter == 3 && LevelSelection3.levelCounter == 4)
            {
                PlayerPrefs.SetInt("lv14", 1);
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        uiCanvas.SetActive(false);
        cf2Panel.SetActive(false);
        cashObject.SetActive(false);
        coinObject.SetActive(false);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        uiCanvas.SetActive(true);
        pausePanel.SetActive(false);
        cf2Panel.SetActive(true);
        cashObject.SetActive(true);
        coinObject.SetActive(true);
    }
    public void Next()
    {
        SceneManager.LoadScene(3);
    }
    public void Home()
    {
        SceneManager.LoadScene(1);
    }
    public void GameFailed()
    {
        if(playerta.GetComponent<FPSPlayer>().hitPoints <= 0 && LevelCompleteCollider.colliderCheck == false && enemyTag.Length>=1 && failCheck == false)
        {
            Time.timeScale = 0;
            failPanel.SetActive(true);
            uiCanvas.SetActive(false);
            cf2Panel.SetActive(false);
            cashObject.SetActive(false);
            coinObject.SetActive(false);
            failCheck = true;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
