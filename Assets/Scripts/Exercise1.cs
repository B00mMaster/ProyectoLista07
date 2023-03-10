using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public GameObject cube;

    public float xRandomPos;
    public float yRandomPos;
    public float zRandomPos;

    



    private void Start()
    {
        

        for (int i = 0; i < 10; i++)
        {



            xRandomPos = Random.Range(-5, 5);
            yRandomPos = Random.Range(-5, 5);
            zRandomPos = Random.Range(-5, 5);

            Vector3 pos = new Vector3(xRandomPos, yRandomPos, zRandomPos);
            GameObject Inst =Instantiate(cube, pos, Quaternion.identity);

            Inst.transform.localScale = Vector3.one*Random.Range(1,3);
            
        }

        
    }
}
