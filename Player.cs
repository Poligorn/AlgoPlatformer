using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Текущее здоровье игрока
    private int health = 10;

    //Число собранных монет
    private int coins;

    //Префаб огненного шара и параметр Transform точки атаки
    public GameObject fireballPrefab;
    public Transform attackPoint;

    //Компонент, отвечающий за проигрывание звуков
    public AudioSource audioSource;

    //Звуковой файл, содержащий звуковой эффект нанесения урона
    public AudioClip damageSound;

    //Метод, обрабатывающий нанесённый урон
    public void TakeDamage(int damage)
    {
        health -= damage;

        //Если здоровье ещё есть, то проигрывается звук нанесения урона
        if(health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            //print("Здоровье игрока: " + health);
        }
        //Если здоровья нет, то перезапускается текущая сцена
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
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
