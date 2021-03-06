﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileGaming
{
    public class GameOver : MonoBehaviour
    {
        public PlayerController player;

        private void Start()
        {
            player = GetComponent<PlayerController>();
        }
        private void Update()
        {
            if (player.isGameOver == true)
            {
                Debug.Log("GameOver");
            }
        }
    }
}

