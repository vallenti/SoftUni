﻿using System;
using System.Collections.Generic;
using System.Linq;

public class GraphConnectedComponents
{
    private static List<int>[] graph;
    private static bool[] visited;

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        graph = new List<int>[n];
        visited = new bool[graph.Length];
        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
            var nodes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            graph[i].AddRange(nodes);
        }

        for (int startNode = 0; startNode < graph.Length; startNode++)
        {
            if (!visited[startNode])
            {
                Console.Write("Connected component:");
                DFS(startNode);
                Console.WriteLine();
            }
        }
    }

    private static void DFS(int node)
    {
        if(!visited[node])
        {
            visited[node] = true;
            foreach (var childNode in graph[node])
            {
                DFS(childNode);
            }

            Console.Write(" " + node);
        }
    }
}
