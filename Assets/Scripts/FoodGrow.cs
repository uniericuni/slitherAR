using UnityEngine;
using System.Collections;

public class FoodGrow : MonoBehaviour {

	public Vector3 startingSize = Vector3.zero;
	public float score = 1.0f;
    private float maxScore;
	public Vector3 maxScale = new Vector3(0.05f, 0.05f, 0.05f);
    private float lifeTimer;
    private float Psize;
    public Vector3 targetScale;

	void Awake() {
		transform.localScale = startingSize;
        maxScore = score;
        maxScale *= 1.0f + score * 0.1f;
        lifeTimer = 10f;
        Psize = GetComponent<ParticleSystem>().startSize;
    }
    void Start()
    {
        transform.localScale = Vector3.Slerp(startingSize, maxScale, Time.deltaTime * 5);
    }

    private Vector3 vel;
    void Update() {
        lifeTimer -= Time.deltaTime;
        if(lifeTimer > 1 ) {
            targetScale = maxScale *= lifeTimer/10;
            transform.localScale = Vector3.Slerp( transform.localScale, targetScale, Time.deltaTime * 5);
            score = maxScore * lifeTimer/10;
            GetComponent<ParticleSystemRenderer>().lengthScale = lifeTimer / 10;
        }
    }
}
