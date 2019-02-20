using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDestruction : MonoBehaviour
{
    public GameObject destroyTrees;
    public GameObject ScoreTextUpdate;
    public ParticleSystem sparkle;
    ScoreVar ScoreTextScript;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Jewel")
        {
            Destroy (col.gameObject);
            ScoreTextScript.score = ScoreTextScript.score + 1;
            print("ScoreTextScript.score");
            sparkle.Emit(500);
            if (ScoreTextScript.score >= 9)
                    {
                        Destroy(destroyTrees);
                    }

        }

        if(col.gameObject.name == "BeveledStar")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene("Title Screen");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreTextScript = ScoreTextUpdate.GetComponent<ScoreVar>();
        destroyTrees = GameObject.FindGameObjectWithTag("newArea");
    }    
    // Update is called once per frame
    void Update()
    {
        
    }
}
