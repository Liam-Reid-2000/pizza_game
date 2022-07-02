using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryInstruction : MonoBehaviour
{

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.getPizzaDelivered())
        {
            //transform.Rotate(0, 0, 1);
        }
    }
}
