using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] message = { "This", "is", "sample", "test" };
        
        StartCoroutine(coRoutines(4f,message));
    }

    // Update is called once per frame
    void Update()
    {
        
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
