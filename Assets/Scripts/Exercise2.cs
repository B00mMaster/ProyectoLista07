using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public int num = 0;

    public TextMeshProUGUI text;

    private void Start()
    {
        StartCoroutine("counter");
    }

    public IEnumerator counter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

           text.text=$"{num}";

            num++;
        }
    }

        

}
