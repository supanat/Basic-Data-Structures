using System;

public class Graph
{

    private const int NUM_VERTICES = 20;
    private Vertex[] vertices;
    private int[,] adjMatrix;
    int numVerts;

    private CStack gStack;

    public Graph()
    {
        vertices = new Vertex[NUM_VERTICES];
        adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
        numVerts = 0;
        for (int j = 0; j < NUM_VERTICES; j++)
        {
            for (int k = 0; k < NUM_VERTICES; k++)
            {
                adjMatrix[j, k] = 0;
            }
        }

        gStack = new CStack();
    }

    public void AddVertex(string label)
    {
        vertices[numVerts] = new Vertex(label);
        numVerts++;
    }

    public void AddEdge(int start, int end)
    {
        adjMatrix[start, end] = 1;
        adjMatrix[end, start] = 1;
    }
    public void ShowVertex(int v)
    {

        Console.Write(vertices[v].label + " ");
    }

    public int NoSuccessors()
    {
        bool isEdge = false;
        for (int row = 0; row <= numVerts - 1; row++)
        {
            isEdge = false;
            for (int col = 0; col <= numVerts - 1; col++)
            {
                if (adjMatrix[row, col] > 0)
                {
                    isEdge = true;
                    break;
                }
            }

            if (!(isEdge))
                return row;
        }

        return -1;

    }

    public void DelVertex(int vert)
    {

        if (vert != numVerts - 1)
        {

            for (int j = vert; j <= numVerts - 1; j++)
            {
                vertices[j] = vertices[j + 1];
            }

            for (int row = vert; row <= numVerts - 1; row++)
            {

            }
        }
    }


    private void MoveRow(int row, int length)
    {
        for (int col = 0; col <= length - 1; col++)
        {
            adjMatrix[row, col] = adjMatrix[row + 1, col];
        }

    }
    private void MoveCol(int col, int length)
    {
        for (int row = 0; row <= length - 1; row++)
        {
            adjMatrix[row, col] = adjMatrix[row, col + 1];
        }
    }

    public void TopSort()
    {
        int origVerts = numVerts;
        while (numVerts > 0)
        {
            int currVertex = NoSuccessors();
            if (currVertex == -1)
            {
                Console.WriteLine("Error: graph has cycles.");
                return;
            }
            gStack.push(vertices[currVertex].label);
            DelVertex(currVertex);
        }

        Console.Write("Topological sorting order: ");
        while (gStack.count > 0)
            Console.Write(gStack.pop() + " ");
    }


    public int GetAdjUnvisitedVertex(int v)
    {
        for (int j = 0; j <= numVerts - 1; j++)
        {

            if ((adjMatrix[v, j] == 1) && (vertices[j].wasVisited == false))
            {
                return j;
            }


        }

        return -1;
    }


    public void DepthFirstSearch() {

        vertices[0].wasVisited = true;
        ShowVertex(0);
        gStack.push(0);
        int v;

        while (gStack.count > 0) {

        }

    }

}