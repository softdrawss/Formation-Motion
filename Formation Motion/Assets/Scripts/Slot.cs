using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public GameObject Target;
    public int Slots;
    public GameObject SlotPrefab;
    
    // THEORY
    // position_slot = position_leader + orientation_leader * position_slotToLeader 
    // orientation_slot = orientation_leader + orientation_slotToLeader

    // Square formation
    // 2 1 2
    // 3 2 3
    // 4 3 4

    // Start is called before the first frame update

}
