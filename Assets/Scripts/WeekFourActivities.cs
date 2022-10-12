using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace DomanikCummings
{
    public class WeekFourActivities : MonoBehaviour
    {
        [SerializeField] private int year;

        // Update is called once per frame
        void Start()
        {
            if (year / 4 > 0)
            {
                Debug.Log("This year is a leap year: " + year);
            }
            else
            {
                Debug.Log("This year is not a leap year: " + year);
            }
        }
    }
}
