using UnityEngine;

public class PizzaBoxScript : MonoBehaviour
{

    public GameObject pizzaBox;
    public GameObject player;
    private bool playerHasPizza;
    private Vector3 pizzaOffset = new Vector3(0f, 3f, 1f);
    private Vector3 pizzaOrigionalLocation = new Vector3(15f, 2.5f, 20f);
    private Quaternion pizzaRotation = new Quaternion();
    public GameManager gameManager;
    public PlayerUI playerUI;

    public int deliveryHouseNumber = 99;

    

    public PizzaBoxScript(int deliveryHouseNumber)
    {
        this.deliveryHouseNumber = deliveryHouseNumber;
    }


    public int getDeliveryHouseNumber()
    {
        return deliveryHouseNumber;
    }

    public void setRandomDeliveryHouseNumber()
    {
        int[] numbers = new int[7] { 96, 97, 98, 99, 101, 102, 103 };
        System.Random rd = new System.Random();
        int randomIndex = rd.Next(0, 7);
        deliveryHouseNumber = numbers[randomIndex];
        
    }




    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null && gameManager.getPizzaDelivered() == false)
        {
            playerInventory.setPizzaDeliveryNumber(deliveryHouseNumber);
            playerHasPizza = true;
            pizzaBox.transform.SetParent(player.transform);
        }
    }

    private void Update()
    {
        if (!playerHasPizza)
        {
            transform.Rotate(0, 1, 0);
            playerUI.SetPizzaText("Collect pizza from pizza place");
        } else
        {
            playerUI.SetPizzaText("Deliver pizza to " + deliveryHouseNumber);
        }
        if (gameManager.getPizzaDelivered() == true)
        {
            resetPizza();
        }
    }

    public void resetPizza()
    {
        pizzaBox.transform.SetParent(null);
        pizzaBox.transform.SetPositionAndRotation(new Vector3(53.2f, 2.5f, -89f), pizzaRotation);
        playerHasPizza = false;
        setRandomDeliveryHouseNumber();
        gameManager.setPizzaDelivered(false);
    }
}
