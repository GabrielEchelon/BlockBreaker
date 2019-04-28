using UnityEngine;

public class Paddle : MonoBehaviour{

    [SerializeField] private float screenWidthInUnits = 16f;
    [SerializeField] private float maxXPos = 15f;
    [SerializeField] private float minXPos = 1f;

    private GameStatus gameStatus;
    private Ball ball;

    private void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        ball = FindObjectOfType<Ball>();
    }

    void Update()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), minXPos, maxXPos);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        if (gameStatus.IsAutoPlayEnabled())
        {
            return ball.transform.position.x;
        }
        else
        {
            float mouseXPos = Input.mousePosition.x / Screen.width * screenWidthInUnits;
            return mouseXPos;
        }
    }
}
