using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DomanikCummings 
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject coinPrefab;
    // Start is called before the first frame update
    void Start()
        {
            SpawnCoin();
            SpawnCoin();
        }

        private void SpawnCoin()
        {
            int xPosition = Random.Range(1, 20);
            int yPosition = Random.Range(1, 20);
            int zPosition = Random.Range(1, 20);
            Instantiate(coinPrefab, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity);
        }
    }
}
