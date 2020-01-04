using UnityEngine;

public class WeaponTester : MonoBehaviour
{
    [SerializeField ]
    private Weapon currentWeapon;
    [SerializeField]
    private Target target;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            currentWeapon.Attack(target);
        }
    }
}
