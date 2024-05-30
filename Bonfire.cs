using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
	//Время жизни огня
	public float lifeTime = 15;
	//Теплоотдача
	public float heatPower = 0.1f;

	//Каждый кадр костёр постепенно угасает, затем исчезает со сцены
	void Update()
	{
		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0)
		{
			gameObject.SetActive(false);
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.GetComponent<Temperature>() != null)
		{
			Temperature temperature = other.GetComponent<Temperature>();
			// Если температура тела игрока меньше нормальной, то согреваем его
			if (temperature.temperatureCurrent < temperature.temperatureNormal)
			{
				temperature.temperatureCurrent += heatPower * Time.deltaTime;
			}
		}
	}
}

