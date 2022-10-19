using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DomanikCummings
{
    public class ContactDirectory : MonoBehaviour
    {
        [SerializeField] private List<ContactInfo> contacts = new List<ContactInfo>();

        private void Start()
        {
            for(int i = 0; i < contacts.Count; i++)
            {
                contacts[i].Initialise();
            }
        }
    }
}
