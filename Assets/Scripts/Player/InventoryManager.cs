using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<WeaponController> weaponSlots = new List<WeaponController>(6);
    public int[] weaponLevels = new int[6];
    public List<PassiveItem> passiveItemSlots = new List<PassiveItem>(6);
    public int[] passiveItemLevels = new int[6];


    public void AddWeapon(int slotIndex, WeaponController weapon)   //Add a weapon to a specific slot
    {
        weaponSlots[slotIndex] = weapon;
    }

    public void AddPassiveItem(int slotIndex, PassiveItem passiveItem)  //Add a passive item to a specific slot
    {
        passiveItemSlots[slotIndex] = passiveItem;
    }

    public void LevelUpWeapon(int slotIndex)
    {

    }

    public void LevelUpPassiveItem(int slotIndex)
    {

    }
}