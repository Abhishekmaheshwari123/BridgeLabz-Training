import java.io.*;
import java.util.*;

public class Main {

    public static void main(String []args){
      Scanner sc = new Scanner(System.in);
      int t = sc.nextInt();
      while(t-- > 0){
        int n = sc.nextInt();
        int[]arr = new int[n];
        for(int i = 0; i < n; i++)arr[i] = sc.nextInt();
        long sum = 0;
        for(int i = 0; i < n-1; i++) {
          sum += Math.abs(arr[i] - arr[i+1]);
        }
        long ans = (int)1e9;
        for(int i = 1; i < n-1; i++){
           ans = Math.min(sum , sum - Math.abs(arr[i] - arr[i-1]) - Math.abs(arr[i] - arr[i+1]) + Math.abs(arr[i-1] - arr[i+1]);
        }
        ans = Math.min(sum , sum - Math.abs(arr[1] - arr[0]));
        ans = Math.min(sum , sum - Math.abs(arr[n-1] - arr[n-2]));
        
        System.out.println(ans);
      }
    }
}
