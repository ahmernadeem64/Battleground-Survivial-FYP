using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour
{
    // Start is called before the first frame update
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
        yield return new WaitForSeconds(2);
           // Application.LoadLevel("Loading");
        SceneManager.LoadScene(1);
    }
}
