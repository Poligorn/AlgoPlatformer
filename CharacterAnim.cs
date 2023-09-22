using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash;

    void Start()
    {
        //Получаем id нужных параметров — так мы сэкономим время на их поиск
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }


    void Update()
    {
        //Получаем по id параметров их булевы значения
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        //Получаем булевы значения результата проверки ввода игрока
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        //Если игрок не идёт И зажата клавиша W, то включаем анимацию ходьбы
        if(!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        //Если игрок идёт И не зажата клавиша W, то выключаем анимацию ходьбы
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        //Если игрок не бежит И зажаты левый шифт И W, то включаем анимацию бега
        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        //Если игрок бежит И не зажат левый шифт ИЛИ W, то включаем анимацию бега
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
