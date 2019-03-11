using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    [SerializeField]
    private int score = 0;

    [SerializeField]
    private Text scoreUI;

    [SerializeField]
    private TextAsset scoreFile; 

    private string preFix = "Score: ";

    private void Awake()
    {
        score = 0;
    }
    
    public void addScore()
    {
        score += 10;
        setScore();

        if (isHighScore())
        {
           // WriteString(score.ToString());
        }
    }

    public void setScore()
    {
        scoreUI.text = preFix + score;
    }

    private bool isHighScore()
    {
        if (score >= Convert.ToInt32(ReadFromFile()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    [MenuItem("Tools/Write file")]
    static void WriteString(string s)
    {
        string path = "Assets/Resources/ScoreData.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(s);
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("ScoreData");

        //Print the text from the file
        Debug.Log(asset.text);
    }

    [MenuItem("Tools/Read file")]
    static string ReadFromFile()
    {
        string path = "Assets/Resources/ScoreData.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        string temp = reader.ReadToEnd();
        reader.Close();
        return temp;
    }

}
