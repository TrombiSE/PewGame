using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BOOM : MonoBehaviour
{
    public void Start()
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

