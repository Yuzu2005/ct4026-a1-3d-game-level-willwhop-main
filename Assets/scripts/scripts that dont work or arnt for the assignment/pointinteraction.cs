using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pointinteraction : MonoBehaviour
{
    [SerializeField]
    private InputActionReference playerInputs;
    float pointerInputValue;
    bool shoot;
    private Camera cam;
    void Awake()
    {
        playerInputs.action.performed += context => pointerInputValue = context.action.ReadValue<float>();

    }

    
    // Start is called before the first frame update
    private void Start()
    {
        cam = Camera.main;
    }



    // Update is called once per frame
    void Update()
    {
        if (pointerInputValue == 1)
        {
            if(shoot == false)
            {
                Shoot();
            }
        }
        else if (pointerInputValue == 0)
        {
            shoot = false;
        }

        void Shoot()
        {
            shoot = true;
            RaycastHit hit;
            if (Physics.Raycast (cam.transform.position, cam.transform.forward, out hit, 100f))
            {
                Debug.Log("Shot" + hit.transform.name);

                if (hit.transform.CompareTag("Door"))
                {
                    hit.transform.GetComponentInParent<Animator>().SetTrigger("updateState");
                }
            }
        }
        
    }
}
