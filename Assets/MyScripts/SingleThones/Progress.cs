using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[System.Serializable]
public static class Progress  
{
   public static List<string> passedLetters = new List<string>();
    public static List<string> passedMissions = new List<string>();


    public static void  LoadData()
    {
        string data = File.ReadAllText("/Resources/db.json"); 
    }

    public static void SaveData()
    {
        string data = JsonUtility.ToJson(Progress.passedLetters);
        File.WriteAllText("/Resources/db.json", data);
        Debug.Log(data);
    }

    

}
