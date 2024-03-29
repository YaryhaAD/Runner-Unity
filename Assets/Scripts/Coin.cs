﻿using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(130 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerManager.numberOfCoins += 1;
            Destroy(gameObject);

        }
    }
}
