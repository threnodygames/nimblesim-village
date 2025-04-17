using NimbleSim;
using UnityEngine;

public class Metabolism
{
  int hunger = 0;
  int thirst = 0;

  void IncreaseHunger() => hunger += 1;
  void IncreaseThirst() => thirst += 1;
  bool Dying() => thirst > 10 || hunger > 20;
  void Die(GameObject actor) => Object.Destroy(actor);

  public Sequence Get()
  {
    return Nimble.Sim()
      .Wait(0.5f)
      .Then(IncreaseHunger)
      .Then(IncreaseThirst)
      .RepeatPreviousUntil(Dying)
      .Then(Die)
      .Done();
  }
}