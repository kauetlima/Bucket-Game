using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5 ;
    void Start()
    {
        
    }

    void Update()
    {
          //Ensure game is Active
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        
        //Get Input Values
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
      
        // abort if no keys are pressed or both are pressed at the same time
        if (left == right)
        {
            return;
        }

        //Move Player
        float movement = speed * Time.deltaTime;
        if (left)
        {
            movement *= -1f;
        }
        transform.position += new Vector3 (movement, 0 ,0);

        //Limit Player Boundaries
       float limit = GameManager.Instance.gameArea / 2;
        if (transform.position.x < -limit){
            transform.position = new Vector3 (-limit,transform.position.y,transform.position.z);
        }
        else if (transform.position.x > limit)
        {
            transform.position = new Vector3 (limit,transform.position.y,transform.position.z);
        }
    }
}

