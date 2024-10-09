using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadTestLevel : MonoBehaviour
{
    bool IsReady = false;
    float timer = 0f;
    
    public void LoadTest()
    {
        SceneManager.LoadScene("TestLevel");
    }

    void Start()
    {
        IsReady = false;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15 && !IsReady)
        {
            GetComponent<Image>().enabled = true;
            GetComponent<Button>().enabled = true;
            GetComponentInChildren<Text>().enabled = true;
            IsReady = true;
        }
    }
}
