using UnityEngine;

public class ObjectActions : MonoBehaviour
{
    // Объявляем переменную для хранения скорости движения объекта
    public float speed = 2f;

    // Объявляем переменную для хранения направления движения
    private Vector3 direction;

    private void Start()
    {
        // Задаем начальное направление движения (вправо)
        direction = Vector3.right;
    }

    private void Update()
    {
        // Перемещаем объект в заданном направлении с определенной скоростью
        transform.Translate(direction * speed * Time.deltaTime);

        // Если объект достигает правой или левой границы экрана, меняем направление на противоположное
        if (transform.position.x >= 5f || transform.position.x <= -5f)
        {
            direction = -direction;
        }
    }
}