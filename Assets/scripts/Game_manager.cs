using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour
{
    bool gameHasEnded = false;
    //public float restartDelay = 0.3f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame(float restartDelay)
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Restart game
            Invoke("Restart", restartDelay);

        }
     
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
