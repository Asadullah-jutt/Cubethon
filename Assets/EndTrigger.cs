using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Gamemanager mane;
    private void OnTriggerEnter()
    {
        mane.GameLevel();
        Invoke("endd", 5);
        
    }

    private void endd()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
