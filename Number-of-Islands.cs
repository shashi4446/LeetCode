public class Solution {
    public int NumIslands(char[][] grid) {
        int count =0;
        
        if(grid == null || grid.Length ==0){
            return count;
        }
        int _r=grid.Length;
        int _c=grid[0].Length;
    
        
        for(int i=0;i<_r;i++){
            for(int j=0;j<_c;j++){
                if(grid[i][j] == '1'){
                    count++;
                }
                DFS(ref grid,i,j,_r,_c);
                
            }
        }
        return count;
    }
    
    public void DFS(ref char[][] grid,int i,int j,int r,int c)
    {
 
        if(i>=0 && i<r && j>=0 && j<c && grid[i][j]=='1'){
            grid[i][j] = '0';
            //DFS(ref grid,i-1,j-1,r,c);
            DFS(ref grid,i-1,j,r,c);
            //DFS(ref grid,i-1,j+1,r,c);
            DFS(ref grid,i,j-1,r,c);
            DFS(ref grid,i,j+1,r,c);
            //DFS(ref grid,i+1,j-1,r,c);
            DFS(ref grid,i+1,j,r,c);
            //DFS(ref grid,i+1,j+1,r,c);
        }
        
        
    }
}