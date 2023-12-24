using UnityEngine;

public class ObjectActions : MonoBehaviour
{
    // ��������� ���������� ��� �������� �������� �������� �������
    public float speed = 2f;

    // ��������� ���������� ��� �������� ����������� ��������
    private Vector3 direction;

    private void Start()
    {
        // ������ ��������� ����������� �������� (������)
        direction = Vector3.right;
    }

    private void Update()
    {
        // ���������� ������ � �������� ����������� � ������������ ���������
        transform.Translate(direction * speed * Time.deltaTime);

        // ���� ������ ��������� ������ ��� ����� ������� ������, ������ ����������� �� ���������������
        if (transform.position.x >= 5f || transform.position.x <= -5f)
        {
            direction = -direction;
        }
    }
}