using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHeight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float randY = Random.Range(.1f, 1);
        transform.localScale = new Vector3 (1,randY, 1);
        transform.localPosition += Vector3.up * randY/2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
