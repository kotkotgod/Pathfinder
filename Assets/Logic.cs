using System.Collections.Generic;
using UnityEngine;

struct Point
{
    public int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Logic
{
    public int[,] field = new int[20, 20];
    Queue<Point> pToCheck = new Queue<Point>();
    Point start = new Point(0, 0);
    Point end = new Point(10, 10);

    public Logic(int[,] inputField)
    {
        pToCheck.Enqueue(start);
    }

    public void OneStep()
    {
        if (pToCheck.Count > 0)
        {
            Point curPoint = pToCheck.Dequeue();
            DoTheThing(curPoint);
        }
        else
        {
            Debug.Log("itsa epty");
        }
    }

    int[,] coord = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 }, { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 } };
    void DoTheThing(Point p)
    {
        int x = p.x;
        int y = p.y;

        for (int i = 0; i < 8; i++)
        {
            int x2 = x + coord[i, 0];
            int y2 = y + coord[i, 1];
            if (x2 > 19 || x2 < 0 || y2 > 19 || y2 < 0) continue;

            if (field[x2, y2] > 0) continue;

            if (field[x2, y2] == -1) continue;

            if (end.x == x2 && end.y == y2) { Debug.Log("path = found"); }

            if (start.x == x2 && start.y == y2) continue;

            field[x2, y2] = field[x, y] + 1;
            pToCheck.Enqueue(new Point(x2, y2));
        }
    }



}
