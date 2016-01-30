#pragma strict
//UIに関するスクリプトをインポートして使えるように
import UnityEngine.UI;
/*

public
var ballPrefab: GameObject;
public
var ballSprites: Sprite[];
 
private
var firstBall: GameObject;
private
var removableBallList: Array;
private
var lastBall: GameObject;
private
var currentName: String;
 */
//ここから下が追加した変数
private
var isPlaying = false; //プレイ中かどうか
 
public
var timer: GameObject; //タイマーとなるオブジェクト
private
var timerText:Text; //タイマーのテキスト
private
var timeLimit = 60; //制限時間
private
var countTime = 5; //カウントダウンの秒数
function Start() {
  timerText = timer.GetComponent(Text); //タイマーを取得
  CountDown(); //カウントダウン開始
  //DropBall(60);
}
 
private
function CountDown() {
  var count = countTime;
  while (count > 0) {
    timerText.text = count.ToString(); //カウントダウンのテキストを変更
    yield WaitForSeconds(1); //1秒待つ
    count -= 1; //カウントを1つ減らす
  }
  timerText.text = "Start!";
  isPlaying = true;
  yield WaitForSeconds(1);
  StartTimer(); //制限時間のカウントを開始
}
 
private
function StartTimer() {
  var count = timeLimit;
  while (count > 0) {
    timerText.text = count.ToString();
    yield WaitForSeconds(1);
    count -= 1;
  }
  timerText.text = "Finish";
  //OnDragEnd();
  isPlaying = false;
}/*
function Update(){
  if(isPlaying){
   if (Input.GetMouseButton(0) && firstBall == null) {
      OnDragStart();
    } else if (Input.GetMouseButtonUp(0)) {
      OnDragEnd();
    } else if (firstBall != null) {
      OnDragging();
    }
  }
}*/
public function Reset(){
  Application.LoadLevel("Main");
}
