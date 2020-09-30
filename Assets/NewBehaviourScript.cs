using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] message = { "This", "is", "sample", "test" };
        
        StartCoroutine(coRoutines(2f,message));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Move(Random.onUnitSphere * 5, 10));
        }
    }

    IEnumerator Move(Vector3 destination, float speed)
    {
        while (transform.position != destination)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed = Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator coRoutines(float wait,string [] message)
    {
        //Debug.Log("Started");
        foreach(string ms in message)
        {
            Debug.Log(ms);
        yield return new WaitForSeconds(wait);
        }
        //Debug.Log("Ended");
    }
}
