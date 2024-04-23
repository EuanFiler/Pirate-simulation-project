using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chests : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entering");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Opening");
            animator.SetBool("open", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exiting");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Exiting");
            animator.SetBool("open", false);
        }
    }
}
