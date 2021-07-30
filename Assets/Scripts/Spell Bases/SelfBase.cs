using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfBase : Initialize
{
    public int healthRestore;

    public void Cast()
    {
        Caster.GetComponent<Status>().Health += healthRestore;
        gameObject.SetActive(false);
    }
}