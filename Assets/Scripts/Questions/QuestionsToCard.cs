using UnityEngine;
using UnityEditor;
using System.IO; 
/*
public class QuestionsToCard
{
    //Find where the CVS is stored
    private static string questionsCVSPath = "/Editor/CSVs/EnemyCSV.csv";

//    [MenuItem("Utilities/Generate Cards")]
    public static void GenerateCard()
    {
        string[] allLines = File.ReadAllLines(Application.dataPath + questionsCVSPath);

        foreach(string s in allLines)
        {
            string[] splitData = s.Split(',');

            if(splitData.Length != 2)
            {
                Debug.Log(s + " does not have 2 values.");
                return; 
            }

            EnterPlayModeOptions card = ScriptableObject.CreateInstance<CardTemplate>();
            card.questionText = splitData[0]; 
            card.questionSource = splitData[1]; 

            AssetDatabase.CreateAsset(card, $"Assets/Enemies/{enemy.enemyName}.asset");
        }

        AssetDatabase.SaveAssets();
    }
}
*/ 
//REVIEW 
//Source -- https://www.youtube.com/watch?v=1EdLTF43d70 
//Everything outside of the editor file is not compiled into the final game.  


