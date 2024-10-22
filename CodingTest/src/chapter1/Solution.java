package chapter1;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

class Solution {
    public int[] solution(int[] array, int[][] commands) {
        int[] answer = new int[commands.length];
        
        for(int index=0; index < commands.length; index++) {
        	int i = commands[index][0]; //시작
        	int j = commands[index][1]; // 끝
        	int k = commands[index][2]; // k번째
        	
        	List<Integer> numList = new ArrayList<>();

        	for(int l= i-1; l < j; l++) {
        		numList.add(array[l]);
        	}
        	
        	Collections.sort(numList);
        	
        	
        	answer[index] = numList.get(k-1);
        	
        }
        
        return answer;
   
    }
    
    public static void main(String[] args) {
        Solution solution = new Solution();
        
        int[] array = {1, 5, 2, 6, 3, 7, 4};
        int[][] commands = {{2, 5, 3}, {4, 4, 1}, {1, 7, 3}};
        
        int[] result = solution.solution(array, commands);
        System.out.println(Arrays.toString(result)); // [5, 6, 3]
    }
}