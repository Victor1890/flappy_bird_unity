using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiperSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public GameObject piper;
    public float height;
    private float timer = 0;

    void Start()
    {
        var newPipe = Instantiate(piper);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }


    void Update()
    {
        if(timer > maxTime)
        {
            var newPipe = Instantiate(piper);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
