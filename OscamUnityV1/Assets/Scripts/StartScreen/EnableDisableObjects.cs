using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableObjects : MonoBehaviour
{
    public GameObject On;
    public GameObject Off;
    public void OnOff()
    {
       if(On !=null)   On.SetActive(true);
       if(Off != null) Off.SetActive(false);
    }
}
