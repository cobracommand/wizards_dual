using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float movementSpeed = 0.1f;
    private bool facingRight = false;
    tk2dSprite sprite;

    void Start() {
        sprite = GetComponent<tk2dSprite>();
    }

    void FlipIfNecessary(bool right) {
        if (right && !facingRight) {
            sprite.FlipX();
            facingRight = true;
        }
        else if (!right && facingRight) {
            sprite.FlipX();
            facingRight = false;
        }
    }

	void Update () {
        if (Input.GetKey(KeyCode.RightArrow)) {
            FlipIfNecessary(true);
            transform.position += Time.deltaTime * movementSpeed * new Vector3(1,0,0);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            FlipIfNecessary(false);
            transform.position -= Time.deltaTime * movementSpeed * new Vector3(1, 0, 0);
        }
	}
}
