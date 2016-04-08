using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class high_score : MonoBehaviour {
	public Text score1;
	public Text score2;
	public Text score3;
	public Text score4;
	public Text score5;
	
	string[] arNama;
	string[] arScore;
	int jum;
	//string[] scoreData;
	
	// Use this for initialization
	void Start () {
		jum= PlayerPrefs.GetInt("Login");
		arNama = new string[jum];
		arScore= new string[jum];
		
		//scoreData = new string[5];
		
		for (int i = 0; i <jum; i++){
			string path=PlayerPrefs.GetString("Highscore" + (i+1));
			Debug.Log("path" + path);
			string[] ar = path.Split(' ');
			String nm = ar[0];
			string sk = ar[10];
			for (int j = 0; j < ar.Length; j++) {
				Debug.Log("DT" + i + " : " +j+'='+ar[j]);
			}
			arNama[i] = nm;
			arScore[i] = sk;
		}
//		SortScores();



		int temp = 0;
		for (int j = 0; j < jum; j++) {
			for (int sort = 0; sort < jum - 1; sort++) {

				int baru=0;
				int lama=0;
				if(arScore[sort].Length<1){arScore[sort]="0";}
				if(arScore[sort+1].Length<1){arScore[sort+1]="0";}

				int.TryParse(arScore[sort], out lama);
				int.TryParse(arScore[sort+1], out baru);

				if (lama < baru) {
					temp = baru;
					arScore[sort + 1] = arScore[sort];
					arScore[sort] = temp.ToString();

					string stemp = arNama[sort+1];
					arNama[sort + 1] = arNama[sort];
					arNama[sort] = stemp;

				}
			}
		}

		//--------------------------------
		for (int i = 1; i <= jum; i++){

			string _HighScore = arNama[i - 1] + "          " + arScore[i - 1];
			PlayerPrefs.SetString("Highscore" + i, _HighScore);
			Debug.Log("Score ke "+ i +" : "+ _HighScore);
		

		}

if (jum == 1) {
			score1.text = arNama [0] + "   " + arScore [0];
		} else if (jum == 2) {
			score1.text = arNama [0] + "   " + arScore [0];
			score2.text = arNama [1] + "   " + arScore [1];
		} 
		else if (jum == 3) {
			score1.text = arNama [0] + "   " + arScore [0];
			score2.text = arNama [1] + "   " + arScore [1];
			score3.text = arNama [2] + "   " + arScore [2];

		} 
		else if (jum == 4) {
			score1.text = arNama [0] + "   " + arScore [0];
			score2.text = arNama [1] + "   " + arScore [1];
			score3.text = arNama [2] + "   " + arScore [2];
			score4.text = arNama [3] + "   " + arScore [3];

		} 

		else if (jum>=5) {
			score1.text = arNama [0] + "   " + arScore [0];
			score2.text = arNama [1] + "   " + arScore [1];
			score3.text = arNama [2] + "   " + arScore [2];
			score4.text = arNama [3] + "   " + arScore [3];
			score5.text = arNama [4] + "   " + arScore [4];
		}

	}
	
	public void kosongkanscore(){
		for (int i = 1; i <= jum; i++)
		{
			PlayerPrefs.SetString("Highscore" + i, "");
		}
		
		PlayerPrefs.SetString("CurrentNama", "");
		PlayerPrefs.SetInt("CurrentScore", 0);
		PlayerPrefs.SetInt("Login", 0);
		Application.LoadLevel(13);
	}


}
