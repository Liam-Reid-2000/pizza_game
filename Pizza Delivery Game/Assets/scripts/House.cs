using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public GameObject successSign;
    public GameManager gameManager;
    public int houseNumber = 99;
    private bool pizzaRecieved = false;

    void Start()
    {
        successSign.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        if (playerInventory.getPizzaDeliveryNumber() == houseNumber)
        {
            successSign.SetActive(true);
            if (gameManager.getPizzaDelivered() == false) gameManager.setPizzaDelivered(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
