using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    //Число собранных монет
    public int coins;

    //Метод, увеличивающий число монеток
    public void CollectCoins()
    {
        coins++;
        //print("Собранные монетки: " + coins);
    }
}
