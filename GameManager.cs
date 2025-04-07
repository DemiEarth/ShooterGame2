using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject coinPrefab;

    public float horizontalScreenSize;
    public float verticalScreenSize;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        horizontalScreenSize = 10f;
        verticalScreenSize = 4f;
        score = 0;
        InvokeRepeating("CreateCoin", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateCoin()
    {
        Instantiate(coinPrefab, new Vector3(Random.Range(-horizontalScreenSize, horizontalScreenSize), Random.Range(-verticalScreenSize, 0), 0), Quaternion.identity);
    }
    public void AddScore(int earnedScore)
    {
        score = score + earnedScore;
    }
}
