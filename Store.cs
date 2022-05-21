using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;
public class Store : MonoBehaviour
{
    public Text cashDisplay;
    public Text coinDisPlay;
    public GameObject cashObject;
    public GameObject coinObject;
    int gunChanger;
    public GameObject m1911Gun, m4Gun, mp5Gun, shotGun, ak47Gun, sniperGun;
    public GameObject m1911Attribute, m4Attribute, mp5Attribute, shotAttribute, ak47Attribute, sniperAttribute;
    public GameObject m1911Panel, m4Panel, mp5Panel, shotPanel, ak47Panel, sniperPanel;
    public GameObject m4PriceTag, mp5PriceTag, shotPriceTag, ak47PriceTag, sniperPriceTag;
    public GameObject purchasedPanel, lowBalance, gunPanel;
    public GameObject m4Lock, mp5Lock, shotLock, ak47Lock, sniperLock;
    public GameObject m4Unlock, mp5Unlock, shotUnlock, ak47Unlock, sniperUnlock;
    public GameObject m4Buy, mp5Buy, shotBuy, ak47Buy, sniperBuy;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        coinDisPlay.text = "" + PlayerPrefs.GetInt("Coins");
        cashDisplay.text = "" + PlayerPrefs.GetInt("Cash");
        purchasedPanel.SetActive(false);
        lowBalance.SetActive(false);
        gunPanel.SetActive(true);
        gunChanger = 1;
        m1911Gun.SetActive(true);
        m1911Attribute.SetActive(true);
        m1911Panel.SetActive(true);
        m4Gun.SetActive(false);
        m4Attribute.SetActive(false);
        m4Panel.SetActive(false);
        m4PriceTag.SetActive(false);
        mp5Gun.SetActive(false);
        mp5Attribute.SetActive(false);
        mp5Panel.SetActive(false);
        mp5PriceTag.SetActive(false);
        shotGun.SetActive(false);
        shotAttribute.SetActive(false);
        shotPanel.SetActive(false);
        shotPriceTag.SetActive(false);
        ak47Gun.SetActive(false);
        ak47Attribute.SetActive(false);
        ak47Panel.SetActive(false);
        ak47PriceTag.SetActive(false);
        sniperGun.SetActive(false);
        sniperAttribute.SetActive(false);
        sniperPanel.SetActive(false);
        sniperPriceTag.SetActive(false);

        if (PlayerPrefs.GetInt("M4") == 1)
        {
            m4Lock.SetActive(false);
            m4Buy.SetActive(false);
            m4PriceTag.SetActive(false);
            m4Unlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MP5") == 1)
        {
            mp5Lock.SetActive(false);
            mp5Buy.SetActive(false);
            mp5PriceTag.SetActive(false);
            mp5Unlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("ShotGun") == 1)
        {
            shotLock.SetActive(false);
            shotBuy.SetActive(false);
            shotPriceTag.SetActive(false);
            shotUnlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Ak47") == 1)
        {
            ak47Lock.SetActive(false);
            ak47Buy.SetActive(false);
            ak47PriceTag.SetActive(false);
            ak47Unlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Sniper") == 1)
        {
            sniperLock.SetActive(false);
            sniperBuy.SetActive(false);
            sniperPriceTag.SetActive(false);
            sniperUnlock.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        Extra();
    }
    public void Extra()
    {
        coinDisPlay.text = "" + PlayerPrefs.GetInt("Coins");
        cashDisplay.text = "" + PlayerPrefs.GetInt("Cash");
        if (PlayerPrefs.GetInt("M4") == 1)
        {
            m4Lock.SetActive(false);
            m4Buy.SetActive(false);
            m4PriceTag.SetActive(false);
            m4Unlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MP5") == 1)
        {
            mp5Lock.SetActive(false);
            mp5Buy.SetActive(false);
            mp5PriceTag.SetActive(false);
            mp5Unlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("ShotGun") == 1)
        {
            shotLock.SetActive(false);
            shotBuy.SetActive(false);
            shotPriceTag.SetActive(false);
            shotUnlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Ak47") == 1)
        {
            ak47Lock.SetActive(false);
            ak47Buy.SetActive(false);
            ak47PriceTag.SetActive(false);
            ak47Unlock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Sniper") == 1)
        {
            sniperLock.SetActive(false);
            sniperBuy.SetActive(false);
            sniperPriceTag.SetActive(false);
            sniperUnlock.SetActive(true);
        }
    }
    public void NextGun()
    {
        if (gunChanger == 1)
        {
            gunChanger = 2;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(true);
            m4Attribute.SetActive(true);
            m4Panel.SetActive(true);
            m4PriceTag.SetActive(true);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 2)
        {
            gunChanger = 3;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(true);
            mp5Attribute.SetActive(true);
            mp5Panel.SetActive(true);
            mp5PriceTag.SetActive(true);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 3)
        {
            gunChanger = 4;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(true);
            shotAttribute.SetActive(true);
            shotPanel.SetActive(true);
            shotPriceTag.SetActive(true);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 4)
        {
            gunChanger = 5;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(true);
            ak47Attribute.SetActive(true);
            ak47Panel.SetActive(true);
            ak47PriceTag.SetActive(true);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 5)
        {
            gunChanger = 6;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(true);
            sniperAttribute.SetActive(true);
            sniperPanel.SetActive(true);
            sniperPriceTag.SetActive(true);
        }
    }
    public void PreviousGun()
    {
        if (gunChanger == 6)
        {
            gunChanger = 5;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(true);
            ak47Attribute.SetActive(true);
            ak47Panel.SetActive(true);
            ak47PriceTag.SetActive(true);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 5)
        {
            gunChanger = 4;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(true);
            shotAttribute.SetActive(true);
            shotPanel.SetActive(true);
            shotPriceTag.SetActive(true);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 4)
        {
            gunChanger = 3;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(true);
            mp5Attribute.SetActive(true);
            mp5Panel.SetActive(true);
            mp5PriceTag.SetActive(true);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 3)
        {
            gunChanger = 2;
            m1911Gun.SetActive(false);
            m1911Attribute.SetActive(false);
            m1911Panel.SetActive(false);
            m4Gun.SetActive(true);
            m4Attribute.SetActive(true);
            m4Panel.SetActive(true);
            m4PriceTag.SetActive(true);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
        else if (gunChanger == 2)
        {
            gunChanger = 1;
            m1911Gun.SetActive(true);
            m1911Attribute.SetActive(true);
            m1911Panel.SetActive(true);
            m4Gun.SetActive(false);
            m4Attribute.SetActive(false);
            m4Panel.SetActive(false);
            m4PriceTag.SetActive(false);
            mp5Gun.SetActive(false);
            mp5Attribute.SetActive(false);
            mp5Panel.SetActive(false);
            mp5PriceTag.SetActive(false);
            shotGun.SetActive(false);
            shotAttribute.SetActive(false);
            shotPanel.SetActive(false);
            shotPriceTag.SetActive(false);
            ak47Gun.SetActive(false);
            ak47Attribute.SetActive(false);
            ak47Panel.SetActive(false);
            ak47PriceTag.SetActive(false);
            sniperGun.SetActive(false);
            sniperAttribute.SetActive(false);
            sniperPanel.SetActive(false);
            sniperPriceTag.SetActive(false);
        }
    }
    public void M4GunPurchase()
    {
        Gameplay.coinCounter = int.Parse(coinDisPlay.text);
        if (Gameplay.coinCounter >= 500)
        {
            Gameplay.coinCounter = Gameplay.coinCounter - 500;
            PlayerPrefs.SetInt("Coins", Gameplay.coinCounter);
            PlayerPrefs.Save();

            purchasedPanel.SetActive(true);
            gunPanel.SetActive(false);
            PlayerPrefs.SetInt("M4", 1);
            PlayerPrefs.Save();
            StartCoroutine(PurchasedPanelFunction());

        }
        else
        {
            lowBalance.SetActive(true);
            gunPanel.SetActive(false);
            StartCoroutine(LowBalancePanelFunction());
        }
    }
    public void MP5GunPurchase()
    {
        Gameplay.coinCounter = int.Parse(coinDisPlay.text);
        if (Gameplay.coinCounter >= 750)
        {
            Gameplay.coinCounter = Gameplay.coinCounter - 750;
            PlayerPrefs.SetInt("Coins", Gameplay.coinCounter);
            PlayerPrefs.Save();

            purchasedPanel.SetActive(true);
            gunPanel.SetActive(false);
            PlayerPrefs.SetInt("MP5", 1);
            PlayerPrefs.Save();
            StartCoroutine(PurchasedPanelFunction());

        }
        else
        {
            lowBalance.SetActive(true);
            gunPanel.SetActive(false);
            StartCoroutine(LowBalancePanelFunction());
        }
    }

    public void ShotGunPurchase()
    {
        Gameplay.coinCounter = int.Parse(coinDisPlay.text);
        if (Gameplay.coinCounter >= 1000)
        {
            Gameplay.coinCounter = Gameplay.coinCounter - 1000;
            PlayerPrefs.SetInt("Coins", Gameplay.coinCounter);
            PlayerPrefs.Save();

            purchasedPanel.SetActive(true);
            gunPanel.SetActive(false);
            PlayerPrefs.SetInt("ShotGun", 1);
            PlayerPrefs.Save();
            StartCoroutine(PurchasedPanelFunction());

        }
        else
        {
            lowBalance.SetActive(true);
            gunPanel.SetActive(false);
            StartCoroutine(LowBalancePanelFunction());
        }
    }

    public void Ak47GunPurchase()
    {
        Gameplay.coinCounter = int.Parse(coinDisPlay.text);
        if (Gameplay.coinCounter >= 1500)
        {
            Gameplay.coinCounter = Gameplay.coinCounter - 1500;
            PlayerPrefs.SetInt("Coins", Gameplay.coinCounter);
            PlayerPrefs.Save();

            purchasedPanel.SetActive(true);
            gunPanel.SetActive(false);
            PlayerPrefs.SetInt("Ak47", 1);
            PlayerPrefs.Save();
            StartCoroutine(PurchasedPanelFunction());

        }
        else
        {
            lowBalance.SetActive(true);
            gunPanel.SetActive(false);
            StartCoroutine(LowBalancePanelFunction());
        }
    }
    public void SniperGunPurchase()
    {
        Gameplay.coinCounter = int.Parse(coinDisPlay.text);
        if (Gameplay.coinCounter >= 1000)
        {
            Gameplay.coinCounter = Gameplay.coinCounter - 1000;
            PlayerPrefs.SetInt("Coins", Gameplay.coinCounter);
            PlayerPrefs.Save();

            purchasedPanel.SetActive(true);
            gunPanel.SetActive(false);
            PlayerPrefs.SetInt("Sniper", 1);
            PlayerPrefs.Save();
            StartCoroutine(PurchasedPanelFunction());

        }
        else
        {
            lowBalance.SetActive(true);
            gunPanel.SetActive(false);
            StartCoroutine(LowBalancePanelFunction());
        }
    }
    IEnumerator PurchasedPanelFunction()
    {
        yield return new WaitForSeconds(2f);
        purchasedPanel.SetActive(false);
        gunPanel.SetActive(true);
    }
    IEnumerator LowBalancePanelFunction()
    {
        yield return new WaitForSeconds(2f);
        lowBalance.SetActive(false);
        gunPanel.SetActive(true);
    }
    public void Rate()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.againto.callofspecialuscombatsecondarymission");

    }
    public void Privacypolicy()
    {
        Application.OpenURL("https://saifsomro999.wixsite.com/againto/callofspecialuscombatsecondarymissi");

    }
    public void More()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=AgainTo+Studio&hl=en");
    }
    public void Back()
    {
        SceneManager.LoadScene(2);
    }
}
