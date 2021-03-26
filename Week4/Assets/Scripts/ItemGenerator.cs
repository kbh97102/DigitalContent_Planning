using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject item;

    private void Start()
    {
        InvokeRepeating("SpawnItem", 1f, 3.0f);
    }

    // Update is called once per frame
    void SpawnItem()
    {
        float rnd = Random.Range(0f, 5.0f);
        Vector3 pos = new Vector3(transform.position.x + rnd, transform.position.y, transform.position.z);

        Instantiate(item, pos, transform.rotation);
    }
}
