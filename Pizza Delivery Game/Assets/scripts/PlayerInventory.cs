
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{

    private int pizzaDeliveryNumber;
    private double funds = 20;
    public PlayerFundsText playerFundsText;
    public UpdateFundsText updateFundsText;

    public bool releasePizza = false;

    public void Start()
    {
        playerFundsText.SetFundsText("$" + funds.ToString("n2"));
    }

    public void setPizzaDeliveryNumber(int pizzaDeliveryNumber)
    {
        Debug.Log(pizzaDeliveryNumber);
        this.pizzaDeliveryNumber = pizzaDeliveryNumber;
    }

    public int getPizzaDeliveryNumber()
    {
        return pizzaDeliveryNumber;
    }

    public void addFunds(double fundsToAdd)
    {
        funds += fundsToAdd;
        playerFundsText.SetFundsText("$" + funds.ToString("n2"));
        updateFundsText.SetUpdateFundsText("+$" + (fundsToAdd*2).ToString("n2")); //this needs to be multiplied by 2 for some reason
    }



}
