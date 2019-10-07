using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGen : MonoBehaviour
{
    public int EdgeLength;
    public GameObject thisCube;
    public float prob;
    public float depth;
    // Start is called before the first frame update
    void Start()
    {
        if (EdgeLength < 4)
        {
            Debug.Log("Edge Length needs to be bigger than 4.");
            return;
        }
        int[,,] indexer = new int[EdgeLength, EdgeLength, EdgeLength];
        for (int i = 0; i < EdgeLength; i++)
        {
            for (int j = 0; j < EdgeLength; j++)
            {
                for (int k = 0; k < EdgeLength; k++)
                {
                    indexer[i, j, k] = 1;
                }
            }
        }
        for (int i = 1; i < EdgeLength-1; i++)
        {
            for (int j = 1; j < EdgeLength-1; j++)
            {
                for (int k = 1; k < EdgeLength-1; k++)
                {
                    indexer[i, j, k] = 0;
                }
            }
        }
        for (int i = 0; i < EdgeLength; i++) {
            for (int j = 0; j < EdgeLength; j++) {
                for (int k = 0; k < EdgeLength; k++) {
                    if (indexer[i, j, k] == 1 && Random.Range(0f, 1f) >= (1f - prob))
                    {
                        GameObject.Instantiate(thisCube, new Vector3(i+depth, j+ depth, k+ depth), Quaternion.identity, transform);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
