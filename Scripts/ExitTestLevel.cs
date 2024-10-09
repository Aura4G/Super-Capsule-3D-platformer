using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTestLevel : MonoBehaviour
{
    bool IsComplete = false;

    void LoadLevel()
    {
        SceneManager.LoadScene("End Screen");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Level Goal"))
        {
            LevelComplete();
        }
    }

    void LevelComplete()
    {
        while (!IsComplete)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            Debug.Log("Level Complete!");
            IsComplete = true;
            Invoke(nameof(LoadLevel), 2f);
        }

    }
}
