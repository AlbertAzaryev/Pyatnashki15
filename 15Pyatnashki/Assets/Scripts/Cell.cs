using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    

    [SerializeField]
  private Text text;
   public int number;
   private int Number
   {
    get
    {
        return number;
    }
    set
    {
        number = value;
        text.text = number.ToString();
    }
   }
  
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
