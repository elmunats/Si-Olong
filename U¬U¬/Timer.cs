using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
	public  GameObject penanganan;
	public  GameObject penyebab;
	public static float timeLeft;
	public Text waktu; 
	public bool resetnya;


	// Use this for initialization
	void Start () {
	
		penyebab.SetActive (true);
		penanganan.SetActive (false);
		resetnya = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Slot.keadaan == true) {
			//Debug.Log("Linked");
			linked ();
			penyebab.SetActive (false);
			penanganan.SetActive (true);
		} else {

			linked2();
			//Debug.Log("Linked2");
		}


	}

	void linked (){

		if(resetnya == true){resetnamanya();
			resetnya =false;
		}

		timeLeft -= Time.deltaTime;
		int berjalan = (int)timeLeft;
		waktu.text = berjalan.ToString ();
		if ( timeLeft < 0 )
		{
			string _varScene,_queryScene;
			_varScene = PlayerPrefs.GetString ("Scene");
			_varScene = "MenuUtama";
			PlayerPrefs.SetString ("Scene", _varScene);
			
			_queryScene = PlayerPrefs.GetString ("Menyimpan");
			_queryScene = "Tambah";
			PlayerPrefs.SetString ("Menyimpan", _queryScene);
			PlayerPrefs.SetInt("Sesuai", 0);
			PlayerPrefs.SetInt("Kotak", 0);	
			Application.LoadLevel(14);
		
		}

		}
	void linked2 (){

		if(resetnya == false){resetnamanya();
			resetnya =true;
		}

		timeLeft -= Time.deltaTime;
		int berjalan = (int)timeLeft;
		waktu.text = berjalan.ToString ();

		if (timeLeft < 0) {
			
			string _varScene,_queryScene;
			_varScene = PlayerPrefs.GetString ("Scene");
			_varScene = "MenuUtama";
			PlayerPrefs.SetString ("Scene", _varScene);
			
			_queryScene = PlayerPrefs.GetString ("Menyimpan");
			_queryScene = "Tambah";
			PlayerPrefs.SetString ("Menyimpan", _queryScene);
			PlayerPrefs.SetInt("Sesuai", 0);
			PlayerPrefs.SetInt("Kotak", 0);	
			Application.LoadLevel (14);
		}
	}
		void resetnamanya(){
			timeLeft = 20f;
		}
		
	}


