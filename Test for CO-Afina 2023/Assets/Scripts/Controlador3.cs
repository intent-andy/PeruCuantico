using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador3 : MonoBehaviour
{
    public GameObject Luz;
    void Start()
    {
       Luz.SetActive(false); 
    }

    // Update is called once per frame
    public void Luz1()
    {
        if(Luz !=null)
        {
            bool IsActive = Luz.activeSelf;
            Luz.SetActive(!IsActive);

        }
    }
}
