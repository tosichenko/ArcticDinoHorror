using System.Collections.Generic;
using UnityEngine;

public class ItemHealth : Health
{
    private List<Transform> _parts = new List<Transform>();

    public override void Death()
    {
        print("umer");
        base.Death();
        foreach (Transform part in GetComponentInChildren<Transform>())
        {
            if (part.GetComponent<Rigidbody>() != null)
            {
                part.GetComponent<Rigidbody>().isKinematic = false;
                print(part.name);
                part.GetComponent<Rigidbody>().AddForce(transform.up, ForceMode.Impulse);
            }
        }
        transform.GetComponent<Collider>().enabled = false;

    }
}
