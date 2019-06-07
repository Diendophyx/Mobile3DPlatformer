using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MobileGaming
{
    public class Timer : MonoBehaviour
    {
        Text text;
        public int timerSpeed = 1;

        private float time;

        private void Start()
        {
            text = GetComponent<Text>();
        }
        private void Update()
        {
            Timing();
        }

        void Timing()
        {
            time += Time.deltaTime * timerSpeed; // this makes sure we are using delta time, but also allows us to times the speed of the timer by x;
            string minutes = Mathf.Floor((time % 3600) / 60).ToString("00"); // this is calculating the minutes by dividing Time by 60*60 which is 3600, and rounding it with Mathf.flor
            string seconds = (time % 60).ToString("00"); // this is calculating the seconds of the time.
            text.text = minutes + ":" + seconds; // this sets the text to say the timer;
        }
    }
}

