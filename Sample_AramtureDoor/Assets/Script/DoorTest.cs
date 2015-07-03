using UnityEngine;
using System.Collections;

public class DoorTest : MonoBehaviour {
	void Awake(){}
	void Start (){}
	void OnApplicationFocus(){}
	void OnApplicationQuit(){}
	void OnApplicationPause(bool pauseStatus) {
		if(pauseStatus){ //Suspend (back to OS)
		}
		else{ //Resume (From OS)
		}
	}
	void OnGUI(){
		DrawGUI(); // 操作ボタン、2D文字描画
	}
	void Update() {
		if(Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape)){//戻るボタン対応
			Application.Quit();
		}
	}
	//============================================================
	void DrawGUI(){
		//if(true)return;
		//Debug.Log ("OnGUI:");
		GUIStyle labelStyle;	//!< GUIフォント表示用スタイル
		int fontRetio = 18;
		
		labelStyle = new GUIStyle();
		labelStyle.fontSize = Screen.width / fontRetio; // Font size
		labelStyle.normal.textColor = Color.grey;
		labelStyle.wordWrap = true;

		float ScrnHor = (float)Screen.width;
		float ScrnVert = (float)Screen.height;
		Rect rectBtn = new Rect(ScrnHor*0.12f,ScrnVert*0.10f,ScrnHor*0.76f,ScrnVert*0.05f);
		if(GUI.Button(rectBtn, "[OPEN]")) {
			animation["Open"].speed = 4.0f;//再生速度指定
			animation.Play("Open");
		}
		rectBtn = new Rect(ScrnHor*0.12f,ScrnVert*0.15f,ScrnHor*0.76f,ScrnVert*0.05f);
		if(GUI.Button(rectBtn, "[CLOSE]")) {
			animation["CLose"].speed = 4.0f;//再生速度指定
			animation.Play("CLose");
		}
	}
}
