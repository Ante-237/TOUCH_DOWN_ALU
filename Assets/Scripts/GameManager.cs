using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
   public static int Score = 0;
   public static int BoxScore = 0;
   public static int SphereScore = 0;
   public static int CylinderScore = 0;

   public void UpdateBoxScore(int amount)
   {
      BoxScore += amount;
   }
}
