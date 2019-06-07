using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MobileGaming
{
    public class GUIManager : MonoBehaviour
    {
        public Text scoreGUI;
        private static int score;

        private void Start()
        {
            GetComponent<Collectable>();
        }

        private void Update()
        {
            CollectablesGUI();
        }

        void CollectablesGUI()
        {
            score = Collectable.playerScore;            // This Grabs the playerscore
            string GUIUpdate = score.ToString("0");     // Converts it to a string ( meaning it can be displayer in text)
            scoreGUI.text = GUIUpdate;                  // This updates the GUI to correspond with players current score
        }
    }
}

