using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetiaryScript : MonoBehaviour
{
    public GameObject Bestiary;
    public bool isBestiaryOpen = false;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        { 
            Bestiary.gameObject.SetActive(!Bestiary.gameObject.activeSelf); 
        }
    }
    public void OpenCloseBestiary()
    {
        //if the bestiary isn't open (in normal gameplay)
        if (isBestiaryOpen == false)
        {
            Bestiary.SetActive(true); //open the bestiary
            gameManager.PauseGame(); //pause the game so player can not continue to move
            isBestiaryOpen = true;
        }
        else //if the bestiary is already open
        {
            Bestiary.SetActive(false); //close the bestiary
            gameManager.UnpauseGame(); //unpause the game so the player may move
            isBestiaryOpen = false;
        }
    }
}
