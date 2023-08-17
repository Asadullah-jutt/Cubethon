using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update

    bool gameended = false;
    public GameObject Gamelevelend;
    public void EndGame()
    {
        if (gameended == false)
        {
            gameended = true;
            Invoke("Restart", 3);
            ;
        }
    }

    void Restart()
    {
        Debug.Log("End game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void GameLevel()
    {
        Gamelevelend.SetActive(true);
        Debug.Log("Game Won");
    }
}
