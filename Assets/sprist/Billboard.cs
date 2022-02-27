using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Billboard : MonoBehaviour
{

    private void Update()
    {
        transform.LookAt(Camera.main.transform);
    }





}
