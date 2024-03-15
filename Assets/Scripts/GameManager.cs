using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(UIManager)), RequireComponent(typeof(SpawnManager))]
public class GameManager : MonoBehaviour
{
   private static int Score = 0;
   private static int BoxScore = 0;
   private static int SphereScore = 0;
   private static int CylinderScore = 0;
   
   public int boxScore
   {
      get { return BoxScore;  }
   }
   public int sphereScore
   {
      get { return SphereScore; }
   }
   public int cylinderScore
   {
      get { return CylinderScore;  }
   }
   public int score
   {
      get { return score;  }
   }
   
   
   public static GameManager Instance;
   private void Awake()
   {
      if (Instance == null)
      {
         Instance = this; 
      }
      else
      {
         Destroy(gameObject); 
      }
   }

   private UIManager UIM;
   private SpawnManager SM;

   private void Start()
   {
      UIM = GetComponent<UIManager>();
      SM = GetComponent<SpawnManager>();
   }
   
   
   public void UpdateScore()
   {
      Score = BoxScore + SphereScore + CylinderScore;
      UIM.ScoreUI(Score);
   }
   
   public void UpdateBoxScore(int amount)
   {
      BoxScore += amount;
      UIM.BoxUI(BoxScore);
      UpdateScore();
   }

   public void UpdateSphereScore(int amount)
   {
      SphereScore += amount;
      UIM.SphereUI(SphereScore);
      UpdateScore();
   }

   public void UpdateCylinderScore(int amount)
   {
      CylinderScore += amount;
      UIM.CylinderUI(CylinderScore);
      UpdateScore();
   }

   public void RestartLevel()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      StartCoroutine(DelaySpawn());
   }

   IEnumerator DelaySpawn()
   {
      yield return new WaitForSeconds(1.0f);
      SM.SpawnRandom();
   }
}
