using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab; // Префаб лунки
    public float minX = -4f; // Минимальное значение X
    public float maxX = 4f; // Максимальное значение X
    public float minY = -4.5f; // Минимальное значение Y
    public float maxY = 4.5f; // Максимальное значение Y

    void Update()
    {
        GenerateHole();
    }

    void GenerateHole()
    {
        if (GameObject.FindGameObjectWithTag("Ball") == null)
        {
            float randomX = Random.Range(minX, maxX); // Генерация случайной позиции X
            float randomY = Random.Range(minY, maxY); // Генерация случайной позиции Y

            Vector2 holePosition = new Vector2(randomX, randomY); // Создание вектора позиции

            Instantiate(ballPrefab, holePosition, Quaternion.identity); // Создание лунки на сгенерированной позиции  
        }

        
    }
}