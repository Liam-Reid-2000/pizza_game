using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool pizzaDelivered = false;
    public PlayerInventory playerInventory;

    public void setPizzaDelivered(bool pizzaDelivered)
    {
        this.pizzaDelivered = pizzaDelivered;
        playerInventory.addFunds(GetRandomTip(10));
    }

    private double GetRandomTip(double maxTip)
    {
        System.Random rand = new System.Random();
        double sample = rand.NextDouble();
        double tip = System.Math.Round((sample * maxTip), 2);
        return tip;
    }

    public bool getPizzaDelivered()
    {
        return pizzaDelivered;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
