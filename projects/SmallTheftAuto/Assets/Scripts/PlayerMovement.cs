using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        Movment();
    }

    public void Movment()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(HorizontalInput, 0, VerticalInput);
        if(HorizontalInput != 0 || VerticalInput != 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetFloat("Speed", 1);
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {
                animator.SetFloat("Speed", -1);
            }
            
        }
        else
        {
            animator.SetFloat("Speed", 0f);
        }
        transform.Translate(direction * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);


    }
}
