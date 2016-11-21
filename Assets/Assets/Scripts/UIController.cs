using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

  private int count;
  public Text countText;
  public Text winText;

  GameObject[] pickups;

  // Use this for initialization
  void Start () {
    count = 0;
    winText.text = "";

    pickups = GameObject.FindGameObjectsWithTag("PickUp");
    SetCountText();    
  }
	
	// Update is called once per frame
	void Update () {

	}

  //Add 1 to count
  public void addCount()
  {
    count++;
  }

  //Add amoutn to count
  public void addCount(int amount)
  {
    count = count + amount;
    SetCountText();
  }

  void SetCountText()
  {
    
    countText.text = "Count: " + count.ToString();

    
    if (count >= pickups.Length)
    {
      winText.text = "You Win!";
    }
  }
}




