using NimbleSim;
using UnityEngine;

public class Villager : MonoBehaviour
{
  Sequence metabolism;

  void Start()
  {
    metabolism = new Metabolism().Get();
  }

  void Update()
  {
    metabolism.Update(gameObject);
  }
}
