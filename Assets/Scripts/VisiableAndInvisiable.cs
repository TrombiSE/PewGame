using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisiableAndInvisiable : MonoBehaviour
{

    public void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    void InvisiableAgain()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().enabled = true;

        }
    }



}
