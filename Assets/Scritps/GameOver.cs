using System;
using UnityEngine;

public class GameOver : MonoBehaviour
{


    void OnCollisionEnter(Collision collision)
    {
        //Ensure game is Active
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }

        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log ("GAME OVER !");

            Destroy(collision.gameObject);

            //End Game
            GameManager.Instance.isGameActive = false;
        }
    }
}
