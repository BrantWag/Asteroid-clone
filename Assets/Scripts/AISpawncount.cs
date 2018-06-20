using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawncount : MonoBehaviour
{

    //Add this object to enemiesSpawned List
    void Start()
    {
        GameManager.instance.enemiesSpawned.Add(this.gameObject);
    }

    // Remove this object from enemiesSpawned List
    void OnDestroy()
    {
        GameManager.instance.enemiesSpawned.Remove(this.gameObject); //telling my gmae manager script to remove this from the enemy spawend list.
    }
}