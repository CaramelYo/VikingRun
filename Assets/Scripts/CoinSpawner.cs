using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    public int Count;

    List<Transform> coinList;


    // Start is called before the first frame update
    void Start()
    {
        coinList = new List<Transform>();

        for (int i = 0; i < Count; ++i)
        {
            Transform c = Instantiate(Coin.transform);
            // "transform" is coin_spawner and p is the one of fixed position
            Transform p = transform.GetChild(Random.Range(0, transform.childCount));

            c.parent = p;
            c.localPosition = Vector3.zero;

            coinList.Add(c);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
