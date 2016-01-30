using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TestGauge : MonoBehaviour {
		public Image CircleGauge;
		
		// Use this for initialization
		void Start ()
		{
				CircleGauge.fillAmount = 1f;
				
		}
		// Update is called once per frame
		void Update ()
		{
            CircleGauge.fillAmount = CircleGauge.fillAmount - 0.006f;
		}
}

