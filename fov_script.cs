using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class fov_script : MonoBehaviour
{
    public float fovAngle = 90f;
    public Transform fovPoint;
    public float range = 8;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //    Vector2 dir = target.position - transform.position;
        //    float angle = Vector3.Angle(dir, fovPoint.up);
        //    RaycastHit2D r = Physics2D.Raycast(fovPoint.position, dir, range);

        //    if (angle < fovAngle / 2) {
        //        if (r.collider.CompareTag("Finish"))
        //        {
        //            print("SEEN!");
        //            Debug.DrawRay(fovPoint.position, dir, Color.red);
        //        }
        //        else {
        //            print("we don't seen");
        //        }
        //    }
        //}
    }
}
