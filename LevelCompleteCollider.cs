using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteCollider : MonoBehaviour
{
    public static bool colliderCheck;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        colliderCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
        //    colliderCheck = true;
        }
    }
}
