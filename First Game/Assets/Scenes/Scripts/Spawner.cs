using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    public GameObject fallingFishPrefab;

    Vector2 screenSizeWorldUnits;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        screenSizeWorldUnits = new Vector2(Screen.width, Screen.)
    }

    // Update is called once per frame
    void Update() {
        Vector2 spawnPosition = new Vector2(Random.Range(-screenSizeWorldUnits.x, screenSizeWorldUnits.x), screenSizeWorldUnits.y);

        // I have to stop here, but I'm following this tutorial: https://www.youtube.com/watch?v=5vov9H7RuF8
    }
}
