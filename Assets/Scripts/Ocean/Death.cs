using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public CharacterController characterController;
    public Transform transform;

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
            characterController.enabled = false;
            transform.position = new Vector3(-23.93f, 4.35f, -45.81f);
            characterController.enabled = true;
        }
    }
}
