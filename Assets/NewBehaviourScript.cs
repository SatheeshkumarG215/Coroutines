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
        StartCoroutine("coRoutines");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator coRoutines()
    {
        Debug.Log("Started");
        yield return new WaitForSeconds(4f);
        Debug.Log("Ended");
    }
}
