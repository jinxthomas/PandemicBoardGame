using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System;

public class BoardManager : MonoBehaviour {

    public List<GameObject> Players = new List<GameObject>();
    private List<City> Cities = new List<City>();

    private int numPlayers = 0;
    private int difficulty = 0;
    public Vector3 position;
    public static string file = "Cities.txt";
    public string input = "";
    

    private struct City
    {
        string name;
        private Vector3 position;

        public City(Vector3 position, string input) : this()
        {
            this.position = position;
            name = input;
        }
    }

    public void MakeGame(int numP, int diff, string[] PNames)
    {
        numPlayers = numP;
        difficulty = diff;

        for(int i = 0; i < numPlayers; i++)
        {
            Players.Add(new GameObject(PNames[i]));
        }
    }

    

    void Update()
    {
        position = Input.mousePosition;

        if(Input.GetButtonDown("Left Click"))
        {
            StreamWriter sw = File.AppendText(file);
            sw.Close();
            File.AppendAllText(file, (input + "\t" + position + "\n"));

            Debug.Log(input + "\t" + position);
        }

        
    }

    
}
