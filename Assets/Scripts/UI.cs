using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileGaming
{
    public class UI : MonoBehaviour
    {
        public GameObject gameOverMenu;
        public PlayerController player;

        private void Start()
        {
            gameOverMenu.SetActive(false);
        }

        void KeepPlaying()
        {
            gameOverMenu.SetActive(false);
        }
        private void Update()
        {
            if (player.isGameOver == true)
            {
                gameOverMenu.SetActive(true);
            }
        }
    }
}

