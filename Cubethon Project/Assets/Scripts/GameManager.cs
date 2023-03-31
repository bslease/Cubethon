using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void Start()
    {
        Time.timeScale = 0.5f;
    }
    public void CompleteLevel()
    {
        //Debug.Log("LEVEL WON!");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            //Debug.Log("GAME OVER!");
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PostProcessLayer p = Camera.main.GetComponent<PostProcessLayer>();
            p.enabled = !p.enabled;
        }
    }
}
