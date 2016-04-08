using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour , IDropHandler{
	string namasimpan, ID;
	string s1,s2,s3,s4,s5,s6,s7,s8,s9;
	public GameObject Benar;
	public GameObject Salah;
	int _tempScore;
	int _sesuai;
	int _kotak;
	int i;
	public static bool keadaan ; 
	
	float timeLeft;
	string _varScene, _queryScene;
	public Text scoreanda;
	public GameObject item {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}
	
	void Start () {
		timeLeft = 2f;
		AudioSource audio = Benar.GetComponent<AudioSource>();
		AudioSource audio2 = Salah.GetComponent<AudioSource>();
		AudioListener lister = Benar.GetComponent<AudioListener>();
		AudioListener lister2 = Salah.GetComponent<AudioListener>();
		
		lister.enabled = false;
		audio.enabled = false;
		lister2.enabled = false;
		audio2.enabled = false;
		
		string _query;
		_query = PlayerPrefs.GetString ("Menyimpan", "");
		//Debug.Log ("querynya : "+_query);
		
		if (_query == "Simpan") {	
			keadaan = false;
			PlayerPrefs.SetInt ("CurrentScore", 0);
			PlayerPrefs.SetInt("Sesuai", 0);
			PlayerPrefs.SetInt("Kotak", 0);	
			PlayerPrefs.SetInt("Kotak", _kotak);
			_tempScore = PlayerPrefs.GetInt("CurrentScore");
			PlayerPrefs.SetInt("CurrentScore", _tempScore);
			namasimpan = PlayerPrefs.GetString("CurrentNama");
			PlayerPrefs.SetString("CurrentNama", namasimpan);
			//Debug.Log("Tambah Score");
			//Debug.Log( "NAMA ANDA : "+namasimpan);
			scoreanda.text = "SCORE : " + _tempScore.ToString ();
			Debug.Log("||"+_varScene);
			
			PlayerPrefs.SetString ("scene1", "");
			PlayerPrefs.SetString ("scene2", "");
			PlayerPrefs.SetString ("scene3", "");
			PlayerPrefs.SetString ("scene4", "");
			PlayerPrefs.SetString ("scene5", "");
			PlayerPrefs.SetString ("scene6", "");
			PlayerPrefs.SetString ("scene7", "");
			PlayerPrefs.SetString ("scene8", "");
			PlayerPrefs.SetString ("scene9", "");
			
		} else {
			_tempScore = PlayerPrefs.GetInt("CurrentScore");
			PlayerPrefs.SetInt("CurrentScore", _tempScore);
			namasimpan = PlayerPrefs.GetString("CurrentNama");
			PlayerPrefs.SetString("CurrentNama", namasimpan);
			//Debug.Log("Tambah Score");
			//Debug.Log( "NAMA ANDA : "+namasimpan);
			scoreanda.text = "SCORE : " + _tempScore.ToString ();
		}
		PlayerPrefs.SetInt("Sesuai", 0);
		PlayerPrefs.SetInt("Kotak", 0);	
		PlayerPrefs.SetInt("Kotak", _kotak);
		
	}
	
	
	
	void AddScore()
	{
		_tempScore = PlayerPrefs.GetInt("CurrentScore");
		_tempScore += 10;
		_sesuai = PlayerPrefs.GetInt("Sesuai");
		_sesuai += 1;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
		PlayerPrefs.SetInt("Sesuai", _sesuai);
		
		
		
		scoreanda.text = "SCORE : " + _tempScore.ToString ();
		
		int _login = PlayerPrefs.GetInt("Login");
		
		string _HighScore = PlayerPrefs.GetString ("Highscore"+_login);
		_HighScore = namasimpan + "          " + _tempScore;
		PlayerPrefs.SetString("Highscore"+_login, _HighScore);
		
	}
	
	void MinScore()
	{
		_tempScore = PlayerPrefs.GetInt("CurrentScore");
		
		
		_tempScore -= 5;
		
		if (_tempScore <= 0 || _tempScore == 0) {
			_varScene = PlayerPrefs.GetString ("Scene");
			_varScene = "MenuUtama";
			PlayerPrefs.SetString ("Scene", _varScene);
			
			_queryScene = PlayerPrefs.GetString ("Menyimpan");
			_queryScene = "Tambah";
			PlayerPrefs.SetString ("Menyimpan", _queryScene);
			PlayerPrefs.SetInt ("Sesuai", 0);
			PlayerPrefs.SetInt ("Kotak", 0);	
			PlayerPrefs.SetInt ("Kotak", _kotak);
			Application.LoadLevel (14);
			
		} else {
			PlayerPrefs.SetInt ("CurrentScore", _tempScore);
		}
		
		
		scoreanda.text = "SCORE : " + _tempScore.ToString ();
		
		int _login = PlayerPrefs.GetInt("Login");
		string _HighScore = PlayerPrefs.GetString ("Highscore"+_login);
		//Debug.Log ("Highscore : " + _HighScore+" Yang Login ke : "+_login);
		_HighScore = namasimpan + "          " + _tempScore;
		PlayerPrefs.SetString("Highscore"+_login, _HighScore);
		
	}
	
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		
		if (!item) {
			
			string dipilih = DragHandeler.tagdipilih.ToString ();
			string slotterpilih = gameObject.tag;
			
			_kotak = PlayerPrefs.GetInt ("Kotak");
			_kotak += 1;
			PlayerPrefs.SetInt ("Kotak", _kotak);
			
			
			
			if (DragHandeler.tagdipilih.Equals (slotterpilih) && DragHandeler.tagdipilih.Equals ("Benar")) {
				AudioSource audio = Benar.GetComponent<AudioSource> ();
				AudioSource audio2 = Salah.GetComponent<AudioSource> ();
				AudioListener lister = Benar.GetComponent<AudioListener> ();
				AudioListener lister2 = Salah.GetComponent<AudioListener> ();
				
				
				lister.enabled = true;
				audio.enabled = true;
				lister2.enabled = false;
				audio2.enabled = false;
				audio.PlayDelayed (0.0f);
				
				
				AddScore ();
				//Debug.Log ("Hasil Penambahan Kotak Ke :" + _kotak);
				//Debug.Log ("Sudah sesuai dengan = " + _sesuai.ToString () + "|Score = " + _tempScore.ToString ());
				
				DragHandeler.itemBeingDragged.transform.SetParent (transform);
				GetComponent<CanvasGroup> ().blocksRaycasts = false;
				ID = PlayerPrefs.GetString ("Scene", "");
				//Debug.Log ("ID nya yaitu : " + ID);
				
				
				
				
				
			} else if (DragHandeler.tagdipilih.Equals (slotterpilih) && DragHandeler.tagdipilih.Equals (_kotak.ToString ())) {
				AudioSource audio = Benar.GetComponent<AudioSource> ();
				AudioSource audio2 = Salah.GetComponent<AudioSource> ();
				AudioListener lister = Benar.GetComponent<AudioListener> ();
				AudioListener lister2 = Salah.GetComponent<AudioListener> ();
				
				lister.enabled = true;
				audio.enabled = true;
				lister2.enabled = false;
				audio2.enabled = false;
				audio.PlayDelayed (0.0f);
				
				
				AddScore ();
				//Debug.Log ("Hasil Penambahan Kotak Ke :" + _kotak);
				//Debug.Log ("Sudah sesuai dengan = " + _sesuai.ToString () + "|Score = " + _tempScore.ToString ());
				
				DragHandeler.itemBeingDragged.transform.SetParent (transform);
				GetComponent<CanvasGroup> ().blocksRaycasts = false;
				
				ID = PlayerPrefs.GetString ("Scene", "");
				//Debug.Log ("ID nya yaitu : " + ID);
				
				
				
				
			} else {
				//Debug.Log ("Belum sesuai");
				AudioSource audio = Benar.GetComponent<AudioSource> ();
				AudioSource audio2 = Salah.GetComponent<AudioSource> ();
				AudioListener lister = Benar.GetComponent<AudioListener> ();
				AudioListener lister2 = Salah.GetComponent<AudioListener> ();
				
				
				lister.enabled = false;
				audio.enabled = false;
				lister2.enabled = true;
				audio2.enabled = true;
				audio2.PlayDelayed (0.0f);
				MinScore();
				GetComponent<CanvasGroup> ().blocksRaycasts = true;
				_kotak = PlayerPrefs.GetInt ("Kotak");
				_kotak -= 1;
				PlayerPrefs.SetInt ("Kotak", _kotak);
				
				//Debug.Log ("Kotak Ke :" + _kotak);
			}
		}
		
	}
	//codingan inti
	void Update (){
		
		if (lukabakarb.jumlahkotak == _kotak && ID.Equals ("Luka Bakar") && keadaan == false) {
			
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
				
				
				_queryScene = PlayerPrefs.GetString ("Menyimpan");
				_queryScene = "Tambah";
				PlayerPrefs.SetString ("Menyimpan", _queryScene);
				keadaan = true;
			}
			
			
			
		} else if (lukabakarn.jumlahkotak == _kotak && ID.Equals ("Luka Bakar") && keadaan == true) {
			
			
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
				
				keadaan = false;
				
				_varScene = PlayerPrefs.GetString ("Scene");
				_varScene = "Luka Sayat";
				PlayerPrefs.SetString ("Scene", _varScene);
				
				_queryScene = PlayerPrefs.GetString ("Menyimpan");
				_queryScene = "Tambah";
				PlayerPrefs.SetString ("Menyimpan", _queryScene);
				
				s1 = PlayerPrefs.GetString("scene1");
				s1 = "Sudah";
				PlayerPrefs.SetString("scene1", s1);
				
				Debug.Log("||"+_varScene);
				Application.LoadLevel (5);
				
				
			}
		}
		
		if (lukasayatb.jumlahkotak == _kotak && ID.Equals ("Luka Sayat") && keadaan == false) {
			
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
				_queryScene = PlayerPrefs.GetString ("Menyimpan");
				_queryScene = "Tambah";
				PlayerPrefs.SetString ("Menyimpan", _queryScene);
				keadaan = true;
				
				
			}
		} else if (lukasayatn.jumlahkotak == _kotak && ID.Equals ("Luka Sayat") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
				
				
				keadaan = false;
				
				_varScene = PlayerPrefs.GetString ("Scene");
				_varScene = "Pingsan";
				PlayerPrefs.SetString ("Scene", _varScene);
				
				_queryScene = PlayerPrefs.GetString ("Menyimpan");
				_queryScene = "Tambah";
				PlayerPrefs.SetString ("Menyimpan", _queryScene);
				s2 = PlayerPrefs.GetString("scene2");
				s2 = "Sudah";
				PlayerPrefs.SetString("scene2", s2);
				
				
				Debug.Log("||"+_varScene);
				Application.LoadLevel (6);
				
			}
		}
		if (pingsanb.jumlahkotak == _kotak && ID.Equals ("Pingsan") && keadaan == false) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
				_queryScene = PlayerPrefs.GetString ("Menyimpan");
				_queryScene = "Tambah";
				PlayerPrefs.SetString ("Menyimpan", _queryScene);
				keadaan = true;
				
				
			}
		} else if (pingsann.jumlahkotak == _kotak && ID.Equals ("Pingsan") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
				
				keadaan = false;
				
				_varScene = PlayerPrefs.GetString ("Scene");
				_varScene = "Terkilir";
				PlayerPrefs.SetString ("Scene", _varScene);
				
				
				
				s3 = PlayerPrefs.GetString("scene3");
				s3 = "Sudah";
				PlayerPrefs.SetString("scene3", s3);
				
				
				Debug.Log("||"+_varScene);
				Application.LoadLevel (7);
				
			}
		}
		if (terkilirb.jumlahkotak == _kotak && ID.Equals ("Terkilir") && keadaan == false) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				}	

		} else if (terkilirn.jumlahkotak == _kotak && ID.Equals ("Terkilir") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Lebam";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s4 = PlayerPrefs.GetString("scene4");
					s4 = "Sudah";
					PlayerPrefs.SetString("scene4", s4);
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (8);
					
				}
			}

		
		//Lebamku
		
		if (lebamb.jumlahkotak == _kotak && ID.Equals ("Lebam") && keadaan == false) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if (timeLeft < 0 || timeLeft == 0) {
				{
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				}
			}
		} else if (lebamn.jumlahkotak == _kotak && ID.Equals ("Lebam") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
				
			if (timeLeft < 0 || timeLeft == 0) {
				{
					
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Gigitan Ular";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s5 = PlayerPrefs.GetString ("scene5");
					s5 = "Sudah";
					PlayerPrefs.SetString ("scene5", s5);
					
					Debug.Log ("||" + _varScene);
					Application.LoadLevel (9);
					
				}
			}
		}
		
		
		if (gigitanularb.jumlahkotak == _kotak && ID.Equals ("Gigitan Ular") && keadaan == false) {
					timeLeft -= Time.deltaTime;
					int berjalan = (int)timeLeft;
					
					if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				
			}
		} else if (gigitanularn.jumlahkotak == _kotak && ID.Equals ("Gigitan Ular") && keadaan == true) {
					timeLeft -= Time.deltaTime;
					int berjalan = (int)timeLeft;
					
					if(timeLeft < 0 || timeLeft == 0){
					
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Tertancap";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s6 = PlayerPrefs.GetString("scene6");
					s6 = "Sudah";
					PlayerPrefs.SetString("scene6", s6);
					
					Debug.Log("||"+_varScene);
					
					Application.LoadLevel (10);
					
				
			}
		}
		if (tertancapb.jumlahkotak == _kotak && ID.Equals ("Tertancap") && keadaan == false) {
					timeLeft -= Time.deltaTime;
					int berjalan = (int)timeLeft;
					
					if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				
			}
		} else if (tertancapn.jumlahkotak == _kotak && ID.Equals ("Tertancap") && keadaan == true) {
					timeLeft -= Time.deltaTime;
					int berjalan = (int)timeLeft;
					
					if(timeLeft < 0 || timeLeft == 0){
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Gigitanlipan";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s7 = PlayerPrefs.GetString("scene7");
					s7 = "Sudah";
					PlayerPrefs.SetString("scene7", s7);
					
					Debug.Log("||"+_varScene);
					
					Application.LoadLevel (11);
				}
			}
			
		
		if (gigitanlipanb.jumlahkotak == _kotak && ID.Equals ("Gigitanlipan") && keadaan == false) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				}
			}

		else if (gigitanlipann.jumlahkotak == _kotak && ID.Equals ("Gigitanlipan") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Lukateriris";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s8 = PlayerPrefs.GetString("scene8");
					s8 = "Sudah";
					PlayerPrefs.SetString("scene8", s8);
					Debug.Log("||"+_varScene);
					
					Application.LoadLevel (12);
					
				}
			}
			

		
		if (lukairisb.jumlahkotak == _kotak && ID.Equals ("Lukateriris") && keadaan == false) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				}
			}

		else if (lukairisn.jumlahkotak == _kotak && ID.Equals ("Lukateriris") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Luka Bakar";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					s9 = PlayerPrefs.GetString("scene9");
					s9 = "Sudah";
					PlayerPrefs.SetString("scene9", s9);
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (4);
					
				}
			}
			

		
		
		
		if (lukabakarb.jumlahkotak == _kotak && ID.Equals ("Luka Bakar") && keadaan == false) {
			for (i = 1; i <= 100; i++) {
				//Debug.Log ("hasil i : " + i);
				
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				
				Debug.Log ("Tampilkan : "+timeLeft.ToString());
				
				if(timeLeft < 0 || timeLeft == 0){
					Debug.Log ("Jalankan");
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
				}
			}
			
			
		} else if (lukabakarn.jumlahkotak == _kotak && ID.Equals ("Luka Bakar") && keadaan == true) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
				
				
				Debug.Log ("Tampilkan : "+timeLeft.ToString());
				
				if(timeLeft < 0 || timeLeft == 0){
					Debug.Log ("Jalankan");
					
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Luka Sayat";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s1 = PlayerPrefs.GetString("scene1");
					s1 = "Sudah";
					PlayerPrefs.SetString("scene1", s1);
					Debug.Log("||"+_varScene);
					Application.LoadLevel (5);
					
				}
			}
		
			}
		if (lukasayatb.jumlahkotak == _kotak && ID.Equals ("Luka Sayat") && keadaan == false) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				
			}
		} else if (lukasayatn.jumlahkotak == _kotak && ID.Equals ("Luka Sayat") && keadaan == true) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Pingsan";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					s2 = PlayerPrefs.GetString("scene2");
					s2 = "Sudah";
					PlayerPrefs.SetString("scene2", s2);
					
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (6);
				
			}
		}
		if (pingsanb.jumlahkotak == _kotak && ID.Equals ("Pingsan") && keadaan == false) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				
			}
		} else if (pingsann.jumlahkotak == _kotak && ID.Equals ("Pingsan") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){		
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Terkilir";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					
					
					s3 = PlayerPrefs.GetString("scene3");
					s3 = "Sudah";
					PlayerPrefs.SetString("scene3", s3);
					
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (7);
				}
			}
		
		if (terkilirb.jumlahkotak == _kotak && ID.Equals ("Terkilir") && keadaan == false) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				
			}
		} else if (terkilirn.jumlahkotak == _kotak && ID.Equals ("Terkilir") && keadaan == true) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Lebam";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s4 = PlayerPrefs.GetString("scene4");
					s4 = "Sudah";
					PlayerPrefs.SetString("scene4", s4);
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (8);
					
				
			}
		}
		
		
		//Lebamku
		
		if (lebamb.jumlahkotak == _kotak && ID.Equals("Lebam") && keadaan == false)
		{
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
				{
					_queryScene = PlayerPrefs.GetString("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString("Menyimpan", _queryScene);
					keadaan = true;
					
				}
			}
		}
		else if (lebamn.jumlahkotak == _kotak && ID.Equals("Lebam") && keadaan == true)
		{
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString("Scene");
					_varScene = "Gigitan Ular";
					PlayerPrefs.SetString("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString("Menyimpan", _queryScene);
					
					s5 = PlayerPrefs.GetString("scene5");
					s5 = "Sudah";
					PlayerPrefs.SetString("scene5", s5);
					
					Debug.Log("||" + _varScene);
					Application.LoadLevel(9);
					
				
			}
		}
		
		
		//Lebamku
		
		
		
		
		if (gigitanularb.jumlahkotak == _kotak && ID.Equals ("Gigitan Ular") && keadaan == false) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				
			}
		} else if (gigitanularn.jumlahkotak == _kotak && ID.Equals ("Gigitan Ular") && keadaan == true) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					
					
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Tertancap";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s6 = PlayerPrefs.GetString("scene6");
					s6 = "Sudah";
					PlayerPrefs.SetString("scene6", s6);
					
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (10);
					
				
			}
		}
		if (tertancapb.jumlahkotak == _kotak && ID.Equals ("Tertancap") && keadaan == false) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					
				
			}
		} else if (tertancapn.jumlahkotak == _kotak && ID.Equals ("Tertancap") && keadaan == true) {
				timeLeft -= Time.deltaTime;
				int berjalan = (int)timeLeft;
				
				if(timeLeft < 0 || timeLeft == 0){
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Gigitanlipan";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s7 = PlayerPrefs.GetString("scene7");
					s7 = "Sudah";
					PlayerPrefs.SetString("scene7", s7);
					
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (11);
				
			}
			
		}
		if (gigitanlipanb.jumlahkotak == _kotak && ID.Equals ("Gigitanlipan") && keadaan == false) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					

			}
		} 
		else if (gigitanlipann.jumlahkotak == _kotak && ID.Equals ("Gigitanlipan") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Lukateriris";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					
					s8 = PlayerPrefs.GetString("scene8");
					s8 = "Sudah";
					PlayerPrefs.SetString("scene8", s8);
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (12);
					
				}
			}
			

		
		if (lukairisb.jumlahkotak == _kotak && ID.Equals ("Lukateriris") && keadaan == false) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					keadaan = true;
					

			}
		} 
		else if (lukairisn.jumlahkotak == _kotak && ID.Equals ("Lukateriris") && keadaan == true) {
			timeLeft -= Time.deltaTime;
			int berjalan = (int)timeLeft;
			
			if(timeLeft < 0 || timeLeft == 0){
					keadaan = false;
					
					_varScene = PlayerPrefs.GetString ("Scene");
					_varScene = "Luka Bakar";
					PlayerPrefs.SetString ("Scene", _varScene);
					
					_queryScene = PlayerPrefs.GetString ("Menyimpan");
					_queryScene = "Tambah";
					PlayerPrefs.SetString ("Menyimpan", _queryScene);
					s9 = PlayerPrefs.GetString("scene9");
					s9 = "Sudah";
					PlayerPrefs.SetString("scene9", s9);
					
					Debug.Log("||"+_varScene);
					Application.LoadLevel (4);
					

			}
			
		}
		
		
		
		
		s1 = PlayerPrefs.GetString("scene1");
		s2 = PlayerPrefs.GetString("scene2");
		s3 = PlayerPrefs.GetString("scene3");
		s4 = PlayerPrefs.GetString("scene4");
		s5 = PlayerPrefs.GetString("scene5");
		s6 = PlayerPrefs.GetString("scene6");
		s7 = PlayerPrefs.GetString("scene7");
		s8 = PlayerPrefs.GetString("scene8");
		s9 = PlayerPrefs.GetString("scene9");
		
		Debug.Log ("s1 = "+s1+" s2 = "+s2+" s3 = "+s3+" s4 = "+s4+" s5 = "+s5+" s6 = "+s6+" s7 = "+s7+" s8 = "+s8+" s9 = "+s9);
		if( s1.Equals( "Sudah") && s2.Equals( "Sudah") && s3.Equals( "Sudah")  && s4.Equals( "Sudah")  && s5.Equals( "Sudah")  && 
		   s6.Equals( "Sudah")  && s7.Equals( "Sudah") && s8 .Equals( "Sudah")  && s9 .Equals( "Sudah") ){
			
			_varScene = PlayerPrefs.GetString ("Scene");
			_varScene = "MenuUtama";
			PlayerPrefs.SetString ("Scene", _varScene);
			
			_queryScene = PlayerPrefs.GetString ("Menyimpan");
			_queryScene = "Tambah";
			PlayerPrefs.SetString ("Menyimpan", _queryScene);
			PlayerPrefs.SetInt("Sesuai", 0);
			PlayerPrefs.SetInt("Kotak", 0);	
			PlayerPrefs.SetInt("Kotak", _kotak);
			
			
			
			Application.LoadLevel (15);
			
		}
	}
	
}


#endregion

