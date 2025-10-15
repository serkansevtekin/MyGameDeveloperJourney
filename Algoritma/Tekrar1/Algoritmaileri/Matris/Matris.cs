using System;

namespace Programlama.Tekrars1.Matris
{
    public class MatrisClass
    {
        public static void MatrisRun()
        {
            //  Grid2DMatris();
            Grid3DMatris();
        }

        #region 2D Grid Üzerinde BFS ve DFS (Kuyruk Tabanlı)
        public static void Grid2DMatris()
        {
            int[,] grid =
            {
                {1,1,0,1},
                {0,1,1,1},
                {1,0,1,0},
                {1,1,1,1},
            };
            bool[,] visited = new bool[4, 4];
            // BFS(grid, visited, 0, 0);
            DFS(grid, visited, 0, 0);
        }

        //Başlangıç noktasından (0,0) tüm geçilebilir hücreleri sırayla gez.
        private static void BFS(int[,] grid, bool[,] visited, int startRow, int startCol)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            //4 yön (yukarı aşağı sol sağ)
            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((startRow, startCol));
            visited[startRow, startCol] = true;

            while (queue.Count > 0)
            {
                var (r, c) = queue.Dequeue();
                System.Console.WriteLine($"Ziyaret: ({r}, {c})");

                for (int i = 0; i < 4; i++)
                {
                    int newR = r + dr[i];
                    int newC = c + dc[i];

                    if (newR >= 0 && newC >= 0 && newR < rows && newC < cols && grid[newR, newC] == 1 && !visited[newR, newC])
                    {
                        visited[newR, newC] = true;
                        queue.Enqueue((newR, newC));
                    }
                }
            }




        }


        //Derinlemesine gez (bir yolda dal, bitince geri dön)
        private static void DFS(int[,] grid, bool[,] visited, int r, int c)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            if (c < 0 || r < 0 || r >= rows || c >= cols || grid[r, c] == 0 || visited[r, c])
            {
                return;
            }

            visited[r, c] = true;
            System.Console.WriteLine($"Ziyaret ({r}, {c})");

            DFS(grid, visited, r - 1, c); // yukarı
            DFS(grid, visited, r + 1, c); // aşağı
            DFS(grid, visited, r, c - 1); // sol
            DFS(grid, visited, r, c + 1); // sağ


        }
        /*
        | Özellik  | BFS                        | DFS                               |
| -------- | -------------------------- | --------------------------------- |
| Yöntem   | Kuyruk (Queue)             | Özyineleme (Recursive) veya Stack |
| Öncelik  | Yakın komşuları önce gezer | Derinlere iner, sonra geri döner  |
| Kullanım | En kısa yol bulma          | Bölge keşfi, bağlantı kontrolü    |
| Bellek   | Fazla (geniş arama yapar)  | Az (derinlik odaklı)              |

        
        */
        #endregion

        #region  3D Grid Üzerinde BFS ve DFS (Kuyruk Tabanlı)
        private static void Grid3DMatris()
        {
            int[,,] grid = new int[,,]
            {
                {
                {1,1,0},
                {1,0,1},
                {1,1,1},
                },
 {
                {1,1,1},
                {0,1,0},
                {1,1,1},
                },
 {
                {1,0,1},
                {1,1,1},
                {0,1,1},
                }
            };

            bool[,,] visited = new bool[3, 3, 3];
            BFS3d(grid, visited, 0, 0, 0);

            System.Console.WriteLine("\nDFS:");
            //  DFS3d(grid, visited, 0, 0, 0);

        }

        private static void DFS3d(int[,,] grid, bool[,,] visited, int x, int y, int z)
        {
            int X = grid.GetLength(0);
            int Y = grid.GetLength(1);
            int Z = grid.GetLength(2);

            if (x < 0 || y < 0 || z < 0 || x >= X || y >= Y || z >= Z)
            {
                return;
            }
            if (grid[x, y, z] == 0 || visited[x, y, z])
            {
                return;
            }

            visited[x, y, z] = true;
            System.Console.WriteLine($"Ziyaret: ({x}, {y}, {z})");

            DFS3d(grid, visited, x + 1, y, z); // sağ
            DFS3d(grid, visited, x - 1, y, z); // sol
            DFS3d(grid, visited, x, y + 1, z); // ileri
            DFS3d(grid, visited, x, y - 1, z); // geri
            DFS3d(grid, visited, x, y, z + 1); // yukarı
            DFS3d(grid, visited, x, y, z - 1); // aşağı

        }


        /*
        MANTIK
            - 3D matrisin her hücresi (x,y,z) kordinatında
            - 6 yön var (ileriye, geriye, yukarı, aşağı, sağa, sola).
            - BFS sırayla bütün komşuları gezer
        
        */
        private static void BFS3d(int[,,] grid, bool[,,] visited, int startX, int startY, int startZ)
        {
            int X = grid.GetLength(0);
            int Y = grid.GetLength(1);
            int Z = grid.GetLength(2);

            //6 yön (ön, arka, yukarı, aşağı, sol , sağ)

            int[] dx = { 1, -1, 0, 0, 0, 0 };
            int[] dy = { 0, 0, 1, -1, 0, 0 };
            int[] dz = { 0, 0, 0, 0, 1, -1 };

            Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
            queue.Enqueue((startX, startY, startZ));
            visited[startX, startY, startZ] = true;

            while (queue.Count > 0)
            {
                var (x, y, z) = queue.Dequeue();
                System.Console.WriteLine($"Ziyaret: ({x},{y}{z})");

                for (int i = 0; i < 6; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];
                    int nz = z + dz[i];

                    if (nx >= 0 && ny >= 0 && nz >= 0 && nx < X && ny < Y && nz < Z && grid[nx, ny, nz] == 1 && !visited[nx, ny, nz])
                    {
                        visited[nx, ny, nz] = true;
                        queue.Enqueue((nx, ny, nz));
                    }

                }
            }



        }

        /*

        | Özellik    | BFS                                 | DFS                          |
    | ---------- | ----------------------------------- | ---------------------------- |
    | Arama tipi | Katman katman                       | Derinlemesine                |
    | Kullanım   | En kısa yol bulma, wave propagation | Hacim keşfi, cluster tespiti |
    | Uygulama   | Queue (kuyruk)                      | Recursive veya Stack         |


    💡 Uygulama Alanları (Unity açısından)

        BFS:

            3D haritada en kısa rota bulmak (ör. AI düşman pathfinding)

            Flood fill (alan genişlemesi)

        DFS:

            3D labirent oluşturma

            Bağlı bölgeleri keşfetme (ör. voxel cluster)

        */

        #endregion
    }
}