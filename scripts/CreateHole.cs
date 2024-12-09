using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHole : MonoBehaviour
{
    public GameObject hole;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameObject.FindGameObjectWithTag("Hole") == null) // Проверка нажатия левой кнопки мыши
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.y += 1.5f;
            Instantiate(hole, mousePosition, Quaternion.identity); // Создание объекта на позиции этого объекта
        }
    }

}
