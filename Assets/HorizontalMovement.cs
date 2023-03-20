using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{

    public float horizontalChange;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += new Vector3(horizontalChange, 0);
    }
}
