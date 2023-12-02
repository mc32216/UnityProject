using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    //
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    //These variables help spawnmanager spawn obstacles
    private float spawnRangeX = 5;
    private float spawnPosY = 1.75f;
    private float spawnPosZ = 44.87f;
    //These variables help with invokeRepeating on startdelay and intrvals(in-between)
    private float startDelay = 2;
    private float spawnInterval = 1;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player1").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);

        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
