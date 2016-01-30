using UnityEngine;
using System.Collections;

public class Count : MonoBehaviour
{
    public int count = 0;
    public int price = 0;
    public int sum = 0;

    void OnCollisionEnter2D(Collision2D col)
    {
        count++;
        Debug.Log(count);
        Debug.Log(col.gameObject.name);

        if (col.gameObject.name == "ring1_a(Clone)")
        {
            Debug.Log("ring1_a hit");
            sum += 100;

            if (col.gameObject.name == "ring2_a(Clone)")
            {
                Debug.Log("ring2_a hit");
                sum += 1000;
            }
            Debug.Log(sum);
        }
    }
}