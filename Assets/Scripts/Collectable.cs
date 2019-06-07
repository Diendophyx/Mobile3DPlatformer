using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileGaming
{
    public class Collectable : MonoBehaviour
    {
        public static int playerScore = 0;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == ("Player"))
            {
                playerScore++; // incriments the playerscore if you come into contact with the player
                Destroy(this.gameObject);
            }
        }
    }
}

