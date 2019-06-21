using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MobileGaming
{
    public class GameOverHandler : MonoBehaviour
    {
        private void Start()
        {
            this.gameObject.SetActive(false);
        }
        private void Update()
        {
            StartAgain();
        }
        public void StartAgain()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Main");
            }
        }
    } 
}
