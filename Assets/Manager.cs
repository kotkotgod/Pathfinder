using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject pixel;

    Logic test = new Logic(new int[2, 2]);




    void Start()
    {
        SpawnPoints(20, 10);

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoStep();
        }
    }

    void DoStep()
    {
        test.OneStep();
        //FieldLog();
    }

    void SpawnPoints(int n, int k)
    {
        float sizeScreenAdapt = PointSize(n, k);
        float sizeMultiplier = sizeScreenAdapt * 0.9f;
        Vector3 topLeft = GetTopLeft(sizeScreenAdapt, n, k);
        //Vector3 topLeft = new Vector3(0, 0, 0);
        Vector3 curPosition = topLeft;
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var pix = Instantiate(pixel, curPosition, Quaternion.identity);
                pix.transform.localScale = new Vector3(sizeMultiplier, sizeMultiplier, sizeMultiplier);
                curPosition.x += sizeScreenAdapt;
            }
            curPosition.y -= sizeScreenAdapt;
            curPosition.x = topLeft.x;
        }
    }

    Vector3 GetTopLeft(float size, int n, int k)
    {
        float x = size * n / 2f;
        float y = size * k / 2f;
        return new Vector3(-x, y, 0);
    }
    float PointSize(int n, int k)
    {
        int x = Screen.width;
        int y = Screen.height;
        int min = Mathf.Min(x / n, y / k);

        return min / 100.0f;
    }


    //void FieldLog()
    //{

    //    StringBuilder sb = new StringBuilder();

    //    for (int i = 0; i < test.field.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < test.field.GetLength(1); j++)
    //        {
    //            sb.Append(test.field[i, j] + "\t");
    //        }
    //        sb.Append("\n");
    //    }
    //    Debug.Log(sb.ToString());
    //}

}
