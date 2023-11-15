using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Максимальное здоровье игрока
    private int health = 10;

    //Число собранных монет
    private int coins;

    //Префаб огненнего шара и параметр Transform точки атаки
    public GameObject fireballPrefab;
    public Transform attackPoint;


    //Метод, понижающий здоровье игрока
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
    }

    //Метод, увеличивающий число монеток
    public void CollectCoins()
    {
        coins++;
        print("Собранные монетки: " + coins);
    }


    void Update()
    {

        //Если игрок кликает левой кнопкой мыши, то создаётся огненный шар
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

    }
}
