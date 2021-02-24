using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ItemBox[] ItemBoxes;
    public GameObject WinUI;

    public bool isGameOver;
    
    void Awake()
    {
        Screen.SetResolution(1024, 768, false);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Screen.SetResolution(Screen.width/2, Screen.height/2, false);
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }

        if(isGameOver == true)    
        {
            return;
        }
        
        int count = 0;
        
        for(int i = 0; i < 3; i++)
        {
           if(ItemBoxes[i].isOveraped == true)
           {
               count++;
           }
        }

        if(count >= 3)
        {
           isGameOver = true;
           WinUI.SetActive(true);
        }
    }
}
