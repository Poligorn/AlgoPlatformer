using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //Текущее здоровье игрока
    public int currenthealth = 10;
    //Максимальное здоровье игрока
    public int maxHealth = 10;
    //Компонент, отвечающий за проигрывание звуков
    public AudioSource audioSource;
    //Звуковой файл, содержащий звуковой эффект нанесения урона
    public AudioClip damageSound;
    //Метод, обрабатывающий нанесённый урон
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        //Если здоровье ещё есть, то проигрывается звук нанесения урона
        if (currenthealth > 0)
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
}
