using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        [SerializeField] public float speed = 100f;
        public Rigidbody2D rb;
        public Vector2 movement;

        public SpriteRenderer spriteRenderer;

        private void Start()
        {
            rb = this.GetComponent<Rigidbody2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }


        private void Update()
        {
            movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            FlipSprite();
        }

        private void FixedUpdate()
        {
            moveCharacter(movement);
        }

        void moveCharacter(Vector2 direction)
        {
            rb.velocity = direction * speed * Time.fixedDeltaTime;
        }

        void FlipSprite()
        {
            float dirX = movement.x;

            if (dirX < 0)
            {
                spriteRenderer.flipX = false; 
            }
            else if (dirX > 0)
            {
                spriteRenderer.flipX = true; 
            }
        }
    }
}
