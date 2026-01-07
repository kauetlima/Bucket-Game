using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
          //Ensure game is Active
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        //Check if other object is a ball
        if (collision.gameObject.CompareTag("Ball"))
        {
            //Increment score
            GameManager.Instance.score++;
             Debug.Log("Score: " + GameManager.Instance.score);

             //Destroy Object
            Destroy(collision.gameObject);  
          
         
        }
        
    }
}
