using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject X_Part;
    public GameObject Y_Part;
    public GameObject Z_Part;
    void FixedUpdate()
    {
        X_Part.transform.Translate(0.1f, 0, 0);
    }
}
