using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build_Simple : MonoBehaviour
{
    public GameObject Hangar_BluePrint;

    public void spawn_Hangar_BluePrint()
    {
        Instantiate(Hangar_BluePrint);
    }
}
