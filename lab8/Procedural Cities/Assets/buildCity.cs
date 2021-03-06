﻿using UnityEngine;
using System.Collections;

public class buildCity : MonoBehaviour {
	
	public GameObject[] buildings;
	public int mapWidth = 20;
	public int mapHeight = 20;
	int buildingFootprint = 3;
	
	void Start (){
		float seed = 62;
		for(int h = 0; h < mapHeight; h++){
			for(int w = 0; w < mapWidth; w++){
				int result = (int) (Mathf.PerlinNoise(w/7.0f,h/9.0f) * 10);
				Vector3 pos = new Vector3(w * buildingFootprint,0,h* buildingFootprint);
				if (result < 1)
					Instantiate(buildings[0], pos, Quaternion.identity);
				else if (result < 2)
					Instantiate(buildings[1], pos, Quaternion.identity);
				else if (result < 4)
					Instantiate(buildings[2], pos, Quaternion.identity);
				else if (result < 5)
					Instantiate(buildings[3], pos, Quaternion.identity);
				else if (result < 7)
					Instantiate(buildings[4], pos, Quaternion.identity);
				else if (result < 10)
					Instantiate(buildings[5], pos, Quaternion.identity);
			}
		}
	}
}