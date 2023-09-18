using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {

        CoinsCounter coins = other.GetComponent<CoinsCounter>();

        //Количество монеток обновляется
        coins.CollectCoins();

        //Монетка, которую собрали, уничтожается
        Destroy(gameObject);
    }
}
