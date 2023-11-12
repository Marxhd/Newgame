using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Transform target;

    [SerializeField] private float Smothspeed;
    [SerializeField]private float minX,maxX,minY,maxY;
    // Start is called before the first frame update
    private void Start()
    {
        target = movement.instance.transform;
        //target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Player");
        //for (int i = 0; i < gameObjects.Length; i++)
        //{
        //    Debug.Log(gameObjects[i].name);

    }

        // Update is called once per frame
        private void LateUpdate()
        {
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, transform.position.z), Smothspeed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        }
}


