using UnityEngine;
using System.Collections;


public class SoundManager : MonoBehaviour {


    public static SoundManager instance=null;
   

    // Use this for initialization
     public void Awake() {



        if (instance != null)
        {
		

            Destroy(gameObject);

        }

        else
        {

            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }



	}

	void Start(){
	
	
	
	
	}



	
	
}
