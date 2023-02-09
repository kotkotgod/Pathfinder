using System.Text;
using UnityEngine;

public class Manager : MonoBehaviour
{
    Logic test = new Logic(new int[2, 2]);




    void Start()
    {
        

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DoStep();
        }
    }

    void DoStep()
    {
        test.OneStep();
        FieldLog();
    }


    void FieldLog()
    {

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < test.field.GetLength(0); i++)
        {
            for (int j = 0; j < test.field.GetLength(1); j++)
            {
                sb.Append(test.field[i, j] + "\t");
            }
            sb.Append("\n");
        }
        Debug.Log(sb.ToString());
    }


}
