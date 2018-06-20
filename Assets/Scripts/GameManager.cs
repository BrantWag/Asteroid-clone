using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    //singleton object set to static
    public static GameManager instance;

    //list
    public GameObject[] enemiesList;
    public Transform[] spawnPoints;
    public List<GameObject> enemiesSpawned;
    public int maxEnemies;

    //player
    public GameObject player;
    public GameObject spawnedPlayer;
    public int playerLives;

    // keeps game controller from being Destroyed 
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        SpawnEnemy();
        SpawnPlayer();
        EndGame();
        
    }
    //for spawning player
    void SpawnPlayer()
    {
        if (spawnedPlayer == null && playerLives > 0) //is playerlives are larger than zero 
        {
            spawnedPlayer = Instantiate(player); //then spaw a player prefab 
        }
    }

    //For spawing enemy 
    void SpawnEnemy()
    {
        // Spawn only 3 enemies
        if (enemiesSpawned.Count < maxEnemies)
        {
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length); // choosing a spawn point
            int randomNum = Random.Range(0, 9);//selecting a random spawn number
            Vector3 spawnNearby = Random.insideUnitCircle;// Sets the position to be somewhere inside a circle
            Vector3 spawnLocation = spawnPoints[randomSpawnPoint].position + spawnNearby;
            Instantiate(enemiesList[randomNum], spawnLocation, spawnPoints[randomSpawnPoint].rotation); 
        }
    }
    void EndGame()
    {
        if (playerLives <= 0) //when players lives are less then zero
        {
            Application.Quit(); //will quit 
            Debug.Log("GAME OVER MAN");//tells you in console that the game is exiting
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //allows me to load another scene 
    }
}
