using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rott3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-90 * Time.deltaTime, 90 * Time.deltaTime,0);
    }
}
