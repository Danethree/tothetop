using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    int time_rate = 0;

    private void OnBecameInvisible()
    {

        Destroy(gameObject,time_rate);
    }
}
