﻿int[][] graph = [
                    [0, 0, 1, 2, 0, 0, 0 ],
                    [ 0, 0, 2, 0, 0, 3, 0 ],
                    [ 1, 2, 0, 1, 3, 0, 0 ],
                    [ 2, 0, 1, 0, 0, 0, 1 ],
                    [ 0, 0, 3, 0, 0, 2, 0 ],
                    [ 0, 3, 0, 0, 2, 0, 1 ],
                    [ 0, 0, 0, 1, 0, 1, 0 ]
                ];
Dijkstra.DijkstraWithAdjacencyMatrix(graph, 6, 2);