using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Здоровье NPC
    public int health = 5;

    //Уровень NPC
    public int level = 1;

    //Скорость NPC
    public float speed = 1.2f;


    void Start()
    {
        health = health + level;
        print("Жизней: " + health);
    }

    void Update()
    {
        //Создаём переменную вида Vector3 и сохраняем в неё позицию NPC
        Vector3 newPosition = transform.position;

        //Меняем позицию NPC по оси z согласно скорости NPC и времени между кадрами
        newPosition.z += speed * Time.deltaTime;

        //Меняем позицию NPC на новое значение, рассчитанное выше
        transform.position = newPosition;
    }
}
