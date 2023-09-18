using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
	public CoinsCounter coinsCount;
	public Health health;
	public TextMeshProUGUI coinsCounterText;
	public Slider healthSlider;

	void Update()
	{
		// Обновляем текст с кол-вом монеток
		coinsCounterText.text = coinsCount.coins.ToString();
		// Обновляем значение здоровья игрока
		healthSlider.maxValue = health.maxHealth;
		healthSlider.value = health.currenthealth;
	}
}
