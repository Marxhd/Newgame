using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go : MonoBehaviour
{
    private float MoveH, MoveV;

    private Rigidbody2D rb;

    [SerializeField] private float movespeed = 0.5f;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        MoveH = Input.GetAxisRaw("Horizontal") * movespeed;
        MoveV = Input.GetAxisRaw("Vertical") * movespeed;
        rb.velocity = new Vector2(MoveH, MoveV);
        Vector2 Direction = new Vector2(MoveH, MoveV);
        //input.x = MoveH;
        //input.y = MoveV;
        if (Direction != Vector2.zero)
        {
            animator.SetFloat("MoveX", MoveH);
            animator.SetFloat("MoveY", MoveV);
        }
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
        
    //       // SceneManager.LoadScene("finally");
       
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
