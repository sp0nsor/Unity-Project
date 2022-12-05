using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    public GameObject flag;
    public GameObject flag2;
    public GameObject flag3;
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
        if (other.gameObject.CompareTag("CheckPoint2"))
        {
            spawnPoint = flag3.transform.position;
            Destroy(flag3);
        }
        if (other.gameObject.CompareTag("CheckPoint"))
        {
            spawnPoint = flag.transform.position;
            Destroy(flag);
        }
        if (other.gameObject.CompareTag("CheckPoint1"))
        {
            spawnPoint = flag2.transform.position;
            Destroy(flag2);
        }
        
    }
}
