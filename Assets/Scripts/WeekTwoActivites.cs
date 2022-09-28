using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DomanikCummings
{
    public class WeekTwoActivites : MonoBehaviour
    {
        private string favouriteGame = "Stellaris";
        private float gameTime = 2300f;
        private float gameCost = 145f;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My Favourite game is " + favouriteGame + ", I have played it for approxamatly " + gameTime + " hours, and it cost me $" + gameCost + ". Therefore, my value of dollars per hour is: $" + gameCost / gameTime + ".");
        }
    }
}

