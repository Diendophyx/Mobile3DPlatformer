using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : OnTriggerEvent
{

  public void DestroyObject()
  {
    Destroy(this.gameObject);
  }
}
