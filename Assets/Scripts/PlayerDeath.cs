using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
   
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Destroy(gameObject);
            //LevelManager.instance.Respawn();
            
            //Task.Delay(1000).Wait();
            //Application.LoadLevel(0);

        }

    }
   


}
