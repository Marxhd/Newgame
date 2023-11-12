using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{

    public string Entrancepw;
    // Start is called before the first frame update
    private void Start()
    {
        if (movement.instance.Pw==Entrancepw) {
            movement.instance.transform.position = transform.position;
        }
    }

  
}
