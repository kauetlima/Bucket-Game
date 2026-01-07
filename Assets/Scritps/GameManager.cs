using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance{get; private set;}
    public int gameWidth { get; internal set; }

    public float gameArea = 15.4f;
    [HideInInspector]
    public int score = 0;
    [HideInInspector]
    public bool isGameActive = true;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
           Instance = this;   
        }
          
    }
   
}
