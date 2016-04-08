using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class input_name : MonoBehaviour {
	public GameObject formInput;
	public GameObject formLevel;
	public InputField textnama;
	string _tempNama;
	int _login;

	// Use this for initialization
	void Start () {
		formLevel.SetActive (false);
		formInput.SetActive (true);

		PlayerPrefs.SetString("CurrentNama", ""); //memberikan default 0


		 _tempNama = PlayerPrefs.GetString("CurrentNama", "");
		 _login = PlayerPrefs.GetInt("Login", 0);

		Debug.Log(_tempNama + "||" + _login);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void klikbuttonOk(){
		_login = PlayerPrefs.GetInt("Login");

		AddNama();
		formLevel.SetActive (true);
		formInput.SetActive (true);
	}

	void AddNama()
	{
		_tempNama = PlayerPrefs.GetString("CurrentNama");
		_tempNama = textnama.text;
		PlayerPrefs.SetString("CurrentNama", _tempNama);

		_login = PlayerPrefs.GetInt("Login");
		_login += 1;
		PlayerPrefs.SetInt("Login", _login);
		Debug.Log( _tempNama +" dengan login ke "+ _login);

		
	
	}


}
