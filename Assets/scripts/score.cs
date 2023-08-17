using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    private int temp;
    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = (int)player.position.z + 44 ;
        scoretext.text = temp.ToString();
    }
}
