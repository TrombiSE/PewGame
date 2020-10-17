using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisiableAndInvisiable : MonoBehaviour
{

    public void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void VisiableAgain()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().enabled = true;

        }
    }
    



}
