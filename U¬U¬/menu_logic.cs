using UnityEngine;
using System.Collections;

public class menu_logic : MonoBehaviour {
	string _varScene,_query;
	// Use this for initialization

	void Start(){
		PlayerPrefs.SetString("Scene", "");
		 
	}

	void Update (){
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 
	}

	public void keylistmenu (){
		Application.LoadLevel (1);
	}
	public void keylistpanduan () {
		Application.LoadLevel (2);
	}
	public void keylistkeluar (){
		Application.LoadLevel (3);
	}

	public void kembali (){
		Application.LoadLevel (0);
	}
	public void keluar (){
		Application.Quit ();
	}
	public void kelukabakar (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Luka Bakar";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(4);
	}
	public void kelukasayat (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Luka Sayat";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(5);
		}
	public void kepingsan (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Pingsan";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(6);
	}
	public void keterkilir (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Terkilir";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(7);
	}
	public void kelebam (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Lebam";
		Debug.Log (_varScene);
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(8);
	}
	public void kegigitanular (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Gigitan Ular";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(9);
	}
	public void ketertancap (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Tertancap";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(10);
	}

	public void kegigitanlipan (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Gigitanlipan";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(11);
	}
	public void kelukairis (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Lukateriris";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(12);
	}

	public void kehighscore (){
		_query = PlayerPrefs.GetString("Menyimpan");
		_query = "Simpan";
		PlayerPrefs.SetString("Menyimpan", _query);
		_varScene = PlayerPrefs.GetString("Scene");
		_varScene = "Highscore";
		PlayerPrefs.SetString("Scene", _varScene);
		Application.LoadLevel(13);
	}
}
