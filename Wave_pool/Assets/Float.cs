using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 pos;
    private int i = 0;
    void Start()
    {
        pos = this.transform.position;
        rb = this.GetComponent<Rigidbody>();
        StartCoroutine("Move");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Move()
    {
        if (i == 0)
        {
            i = 1;
            yield return new WaitForSeconds((pos.x+7.5f) / 21);
        }
        while (true)
        {
            rb.AddForce(0, 3500f, 0);
            yield return new WaitForSeconds(6.3f);
        }
    }

}
