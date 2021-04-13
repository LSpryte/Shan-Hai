using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    public bool CanInteract = false;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "NPC")
        {
            CanInteract = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        CanInteract = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && CanInteract) 
        {
            Debug.Log("Talking to ; ");
        }
    }
}
