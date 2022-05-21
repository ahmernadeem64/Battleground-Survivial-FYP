using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(NewScene());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator NewScene()
    {
        yield return new WaitForSeconds(5);
        // Application.LoadLevel("MainMenu");
        SceneManager.LoadScene(2);

    }
}
