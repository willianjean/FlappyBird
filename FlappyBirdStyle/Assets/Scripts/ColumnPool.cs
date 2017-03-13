using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-15f, 25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentColumn = 0;

    //fruit
    public GameObject fruitPrefab;
    private GameObject[] fruits;
    int primeiro = 0;

    // Use this for initialization
    void Start () {

        //fruit
        fruits = new GameObject[columnPoolSize];

        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);

            //fruit
            fruits[i] = (GameObject)Instantiate(fruitPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime;
		
        //atualizado spawnRate
        if(GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate-1.5f)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);


            //fruit
            fruits[currentColumn].transform.position = new Vector2(18f, Random.Range(columnMin, columnMax));
            

            currentColumn++;
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
	}
}
