using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    // Intervalo para criação das bolinhas : publico
    // Cooldown : privado
    // Lista de bolinhas : Publico
    // Ponto de Origem : publico

    public Vector3 originPoint = new Vector3 (0,0,0);
    public List<GameObject> prefabs;
    public float interval = 1;
    private float cooldown  = 0;

    void Start()
    {
        
    }

    void Update()
    {
        // Ensure game is active
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        


        //Spawn Ball according to interval
       cooldown -= Time.deltaTime;
       if(cooldown <= 0f)
        {
            cooldown = interval;
            SpawnBall();
        } 
    }

    private void SpawnBall()
    {
        int prefabIndex = Random.Range(0,prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];

        //Get position
        float area = GameManager.Instance.gameArea;
        float x = Random.Range(-area / 2f, area /2f);
        Vector3 position = originPoint + new Vector3(x, 0 ,0);


        //Get rotation
        Quaternion rotation = prefab.transform.rotation;


        //SpawnBall
        Instantiate(prefab, position, rotation);
    }
}
