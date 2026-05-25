using System.Collections;
using UnityEngine;

public class biggie_cube : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ScaleSize());
    }
    // Update is called once per frame
    IEnumerator ScaleSize()
    {
        while (true)
        {
            int i = 20;
            for (; i < 60;)
            {
                transform.localScale = Vector3.one * i/20;
                yield return new WaitForSeconds(0.01f);
                i++;
            }
            yield return new WaitForSeconds(0.2f);

            for (; i != 20;) 
            {
                transform.localScale = Vector3.one * i/20;
                yield return new WaitForSeconds(0.01f);
                i--;
            }


        }
    }
}

