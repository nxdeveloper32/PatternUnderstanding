using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private int currentHealth = 10;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Damage" + amount + "Health" + currentHealth);
    }
}
