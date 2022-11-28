using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public GameObject flag;
    Vector3 spawnPoint;

    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }
    void Update()
    {
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("CheckPoint"))
        {
            spawnPoint = flag.transform.position;
            Destroy(flag);
        }
    }
}
