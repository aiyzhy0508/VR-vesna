using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restore : MonoBehaviour
{
    public GameObject MT;
    public GameObject[] MT_Parts;
    public GameObject Rspawn;

    public void RS() {
        MT_Parts = GameObject.FindGameObjectsWithTag("MT");
        foreach (GameObject gm in MT_Parts)
        {
            Destroy(gm);
        }
        Instantiate(MT, Rspawn.transform.position, Quaternion.identity);
    }
}
